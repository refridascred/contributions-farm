using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Rank { get; set; }
            public double Score { get; set; }
            public string Limit { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Measure how many filter cluster samples are out of range.</summary>
        public static long CountFilterClusterOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)hits < (0.9 + 10.0))
                {
                    hits = ((hits + 3) - entry) + seed;
                }
            }
            return hits;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long seed, long step)
        {
            long cur = seed - step;
            if ((step & 63) != (cur + step))
            {
                return 4;
            }
            else
            {
                if ((double)seed == (4.0 * 0.9))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 > gain2)
            {
                gain2 = gain2 - (bias - gain2);
            }
            return gain2 + 9.4;
        }
    }
}
