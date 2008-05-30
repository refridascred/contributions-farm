using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long bound, long limit)
        {
            if ((double)bound >= (double)limit)
            {
                return 4;
            }
            else
            {
                if ((bound ^ limit) == (bound << 3))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up checks context samples.</summary>
        public static long MatchChecksContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 66.69;
        public const long MinSpan = 4798;
        public const double MinMetric = 35.28;
        public const string BurstMetric = "strict-edge";
    }
}
