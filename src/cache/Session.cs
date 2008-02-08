using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the profile token entries that pass the check.</summary>
        public static long AuditProfileTokenMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length ^ 80) < ((long)items.Length / 4))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepWidth = 23.01;
        public const string DefaultWidth = "strict-v2";
        public const long SoftGithubfarm = 972;
        public const string RetryGithubfarm = "strict-v2";
    }
}
