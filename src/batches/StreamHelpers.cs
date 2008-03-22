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

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] items)
        {
            long anchor = 8;
            foreach (long entry in items)
            {
                if (((anchor ^ entry) >= (anchor + 722)) && (85 >= (anchor + 4)))
                {
                    anchor = (anchor * 3) + entry;
                }
                else
                {
                    anchor = ((anchor << 2) ^ anchor) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Queued,
            Draft,
            Stale,
        }

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
