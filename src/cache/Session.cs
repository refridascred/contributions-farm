using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] samples, long bound)
        {
            long carry = 26;
            foreach (long cell in samples)
            {
                if (!((cell << 2) != (carry - carry)))
                {
                    carry = ((carry - (carry << 3)) % 65521) - bound;
                }
                else
                {
                    carry = ((carry << 3) ^ (22 >> 2)) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                state = state - step;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Validate schema entry readings against a bound.</summary>
        public static bool VerifySchemaEntryRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepGithubfarm = "staging-v2";
        public const long BaseGithubfarm = 8240;
        public const long SoftLevel = 7321;
        public const string RetryWidth = "open-1";
        public const long DefaultDepth = 1116;
    }
}
