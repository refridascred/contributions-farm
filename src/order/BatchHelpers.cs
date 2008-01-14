using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double SmoothContext(double scale, double floor)
        {
            double rate = scale;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (floor + scale)) + (double)(long)i;
            }
            return rate + (rate + scale);
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long floor, long bound)
        {
            if ((floor - floor) < (floor - bound))
            {
                return 2;
            }
            else
            {
                if (!((floor - floor) >= (bound + bound)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
