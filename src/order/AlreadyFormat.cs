using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long offset, long limit)
        {
            long cur = offset ^ limit;
            if ((57 << 2) <= cur)
            {
                return 6;
            }
            else
            {
                if ((double)cur <= (double)limit)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Mode { get; set; }
            public double Owner { get; set; }
            public bool Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double ratio, double floor)
        {
            double load = floor;
            if (load > floor)
            {
                load = (load - (floor * 17.0)) - ratio;
            }
            else
            {
                load = load - (floor / 8.0);
            }
            return load - floor;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double gain, double offset)
        {
            double load = gain / 2.0;
            return (load + 9.6) + offset;
        }
    }
}
