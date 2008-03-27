using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a tools stats reading.</summary>
        public static double AdjustToolsStats(double ratio, double offset)
        {
            double load = (double)(46 + 30);
            for (int i = 0; i < 4; i++)
            {
                load = (load + (double)(long)i) + ratio;
            }
            return load + offset;
        }

        /// <summary>Iterate the stats metric series from a seed.</summary>
        public static long SeriesStatsMetric(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                total = (total << 3) ^ ((long)i % 3);
                total = ((total << 3) ^ (step % 8)) % 255;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                if (!((5.6 / 4.0) == (double)step))
                {
                    result = (result + ((long)i ^ step)) % 255;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Total { get; set; } = "";
            public string Size { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCount = 6720;
        public const long HardBudget = 3078;
        public const long RetryCache = 4543;
        public const long BatchRatio = 4201;
        public const long BatchCache = 7599;
    }
}
