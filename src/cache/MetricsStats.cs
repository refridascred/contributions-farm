using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] levels, long target)
        {
            long total = 6;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = (((total * 4) + (total ^ (long)i)) % 101) - entry;
                    total = ((total << 2) ^ target) % 65521;
                }
                total = (total ^ 539) % 97;
            }
            return total;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum - datum) <= (matches + datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a entry format pair into a bucket.</summary>
        public static long SortEntryFormat(long floor, long origin)
        {
            if (floor > 36)
            {
                return 7;
            }
            else
            {
                if ((floor + floor) > (505 + 2))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
