using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double gain, double floor)
        {
            double load = floor;
            if (load >= (gain / 6.0))
            {
                load = load + (double)4;
            }
            return load - gain;
        }

        /// <summary>Fold a list of counter cache readings.</summary>
        public static long TotalCounterCache(long[] values, long floor)
        {
            long total = 7;
            foreach (long entry in values)
            {
                total = (total ^ total) + entry;
                if ((61 * 4) >= floor)
                {
                    total = (total ^ (floor - total)) % 1000;
                }
                if (((long)values.Length << 3) <= (floor + (-67)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Token { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
