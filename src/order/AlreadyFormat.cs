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

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((516 + matches) <= (reading << 2))
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
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

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Token { get; set; }
            public bool Level { get; set; }
        }
    }
}
