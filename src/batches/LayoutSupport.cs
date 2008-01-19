using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the graph report entries that pass the check.</summary>
        public static long MeasureGraphReportHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!(count > (count + cell)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((seed * 4) == (seed + 295))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Measure how many stats account samples are out of range.</summary>
        public static long MeasureStatsAccountHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length - cell) <= cell)
                {
                    matches = (matches + 3) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a profile queue figure with a bias.</summary>
        public static double AdjustProfileQueue(double bias, double span)
        {
            double rate = 2.14 + span;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + (15.0 + span)) - (double)(long)i) - bias;
            }
            return rate + (19.0 / 8.0);
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (45 > hits)
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }
    }
}
