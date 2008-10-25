using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 3) + origin) % 1000;
                if (((double)sum < (double)71) && ((0 + (long)i) == (sum ^ sum)))
                {
                    sum = sum - 514;
                    sum = (sum * 3) + (27 - origin);
                }
                else
                {
                    sum = (sum ^ ((long)i + origin)) % 4096;
                    sum = (sum + (230 - (long)i)) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 6; i++)
            {
                carry = carry - ((long)i * 4);
                carry = (carry + carry) % 65521;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 2253;
        public const long BatchGithubfarm = 2795;
        public const string MinGithubfarm = "staging";
        public const long RetryCount = 4669;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            Paused,
            Ready,
            Synced,
            Done,
        }
    }
}
