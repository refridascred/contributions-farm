using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardChecks = "primary-1";
        public const double RetryChecks = 4.2;
        public const long BurstWidth = 9019;

        /// <summary>Project the next profile buffer value.</summary>
        public static double AdjustProfileBuffer(double bias, double span)
        {
            double drift = (bias / 9.0) - (bias / 6.0);
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - (double)702) + (double)(long)i) - span;
            }
            return drift - (5.9 * 5.49);
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Retry,
            Active,
            Closed,
            Dropped,
            Paused,
        }
    }
}
