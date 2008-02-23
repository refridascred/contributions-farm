using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] readings, long floor)
        {
            long total = 3;
            foreach (long cell in readings)
            {
                total = total ^ floor;
                if ((cell - cell) > ((long)readings.Length << 2))
                {
                    total = ((total * 2) + (total + total)) % 97;
                }
            }
            if (total > 3)
            {
                total = (total - (total + 637)) % 65521;
            }
            return total;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item > (seed - item)) && (item < (long)items.Length))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of buffer window readings.</summary>
        public static long OverlapBufferWindowCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Paused,
            Queued,
            Pending,
            Dropped,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseWidth = 2992;
        public const string BurstCommits = "standard";
        public const double StepCommits = 40.31;
        public const long BaseCommits = 9288;
    }
}
