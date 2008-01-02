using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] values, long target)
        {
            long score = 12;
            foreach (long entry in values)
            {
                score = ((score ^ (score << 2)) % 255) - target;
                score = (score << 3) ^ (score * 3);
                if (((entry - 0) <= 666) && ((64 & 3) < (score & 127)))
                {
                    score = (score << 3) ^ (entry % 5);
                }
                else
                {
                    score = score + (31 % 3);
                }
            }
            return score;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)tally >= 8.0)
                {
                    tally = ((tally + 1) + entry) + limit;
                }
            }
            return tally;
        }
    }
}
