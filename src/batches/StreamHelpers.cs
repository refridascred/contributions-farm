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

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Count report session pairs that satisfy a relation.</summary>
        public static long OverlapReportSessionCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double scale, double bias)
        {
            double weight = scale - 1.5;
            if (weight >= (scale * 19.0))
            {
                weight = (weight - (scale / 6.0)) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + weight;
        }
    }
}
