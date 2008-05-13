using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((seed * 4) != (acc + 264))
                {
                    acc = ((acc << 2) ^ (acc / 6)) % 255;
                    break;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit metrics contributi readings against a rule.</summary>
        public static long CountMetricsContributiOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((((limit - 885) == (953 - entry)) && ((double)entry == (double)limit)) && !((double)entry != (9.9 / 4.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Level { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
