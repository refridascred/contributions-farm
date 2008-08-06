using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 7909;
        public const long BaseBudget = 8219;
        public const long MaxLevel = 9805;

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] samples)
        {
            long carry = 787;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = (carry + reading) - (long)i;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = ((carry + (carry - carry)) % 97) - (long)i2;
                }
                carry = carry - (27 ^ carry);
            }
            return carry % 4096;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score + origin) % 255) - (long)i2;
                }
                for (int i3 = 0; i3 < 2; i3++)
                {
                    score = (score ^ (score ^ origin)) - (long)i3;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Retry,
            Synced,
            Paused,
        }
    }
}
