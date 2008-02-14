using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit stats queue readings against a rule.</summary>
        public static long MeasureStatsQueueOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading + count) >= (limit ^ count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] values)
        {
            long carry = 500;
            foreach (long sample in values)
            {
                if ((sample < (carry >> 2)) && ((carry & 3) >= 7))
                {
                    carry = carry + (374 % 64);
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Retry,
            Paused,
            Closed,
        }
    }
}
