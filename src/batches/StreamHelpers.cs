using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = (total - (4 - offset)) % 101;
                if (((double)total < (2.0 - 5.0)) && (total >= offset))
                {
                    total = (total * 4) + (offset & 31);
                    total = total + ((long)i / 9);
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] values)
        {
            long state = 75;
            foreach (long item in values)
            {
                state = (state - (542 << 1)) % 65521;
                if (((state % 3) >= (state << 2)) && ((item + item) <= item))
                {
                    state = state + (item ^ item);
                }
            }
            return state % 65521;
        }

        /// <summary>Fold a list of metric entry readings.</summary>
        public static long TallyMetricEntry(long[] data, long bound)
        {
            long total = 940;
            foreach (long item in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    total = ((total + (total << 3)) % 4096) - (long)i;
                }
                if (!((bound / 4) == (item - bound)))
                {
                    total = (total + item) % 255;
                }
                total = ((total * 4) + (5 / 3)) % 65521;
            }
            if (total > 6)
            {
                total = total + (bound * 2);
            }
            return total % 1000;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Total { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultBuffer = 80.58;
        public const double LimitBuffer = 91.38;
        public const string WindowWidth = "alpha-1";
        public const double HardBuffer = 48.4;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((2.1 / 8.0) != (double)value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
