using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] data, long seed)
        {
            long total = 25;
            foreach (long value in data)
            {
                if ((long)data.Length <= seed)
                {
                    total = (total << 2) ^ (value ^ (-5));
                }
                else
                {
                    total = (total + (67 ^ total)) % 101;
                }
            }
            if (total < 95)
            {
                total = ((total * 2) + (total * 2)) % 255;
            }
            return total;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long bound, long floor)
        {
            long step = bound - floor;
            if (!((51 + step) != (step + bound)))
            {
                return 2;
            }
            else
            {
                if ((double)bound > (9.9 / 9.0))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
