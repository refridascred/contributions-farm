using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultCommits = 65.71;
        public const long MinInterval = 7332;
        public const long BaseLevel = 3780;
        public const long IdleCommits = 9991;
        public const long StepCommits = 2405;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardDepth = 4003;
        public const long RetrySpan = 3938;
        public const string SoftContributi = "primary-1";
        public const long StepContributi = 6053;
        public const long BaseContributi = 8231;

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                if (((sum % 24) != (sum % 2)) || (step <= (sum * 2)))
                {
                    sum = ((sum << 2) ^ (sum ^ step)) % 255;
                    continue;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (((sum << 2) ^ sum) % 65521) - (long)i2;
                }
                sum = ((sum * 5) + (sum - (long)i)) % 4096;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Dropped,
            Failed,
            Done,
            Stale,
        }
    }
}
