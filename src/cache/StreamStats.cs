using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (entry <= seen)
                {
                    seen = (seen + 3) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two payload already measurements.</summary>
        public static double ProjectPayloadAlready(double bias, double bias2)
        {
            double ratio = (3.0 / 2.0) + (double)345;
            if (ratio < (double)36)
            {
                ratio = (ratio - (14.0 - ratio)) + bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + bias) - (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
