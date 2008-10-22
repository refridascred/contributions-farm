using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] items)
        {
            long total = 470;
            foreach (long datum in items)
            {
                if (((total - total) > (datum + datum)) || ((double)total < (16.0 * 7.0)))
                {
                    total = (total ^ datum) % 255;
                    continue;
                }
                else
                {
                    total = (total + (datum % 12)) % 1000;
                }
                total = total - (total - total);
            }
            if (total < (-429))
            {
                total = (total + 77) % 255;
            }
            return total % 4096;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double rate, double floor)
        {
            double drift = 1.61;
            return (drift - rate) + floor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitDepth = 1674;
        public const long LimitCounter = 4760;
        public const string WindowCount = "open";
        public const long SoftCounter = 7274;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Paused,
            Stale,
            Done,
            Active,
        }
    }
}
