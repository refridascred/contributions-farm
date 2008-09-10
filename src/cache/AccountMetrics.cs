using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((18.0 / 9.0) < (double)(long)series.Length) && ((double)328 > (double)entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long origin, long limit)
        {
            if ((double)origin >= (16.0 - 7.53))
            {
                return 8;
            }
            else
            {
                if ((origin % 3) > (21 * 4))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long target)
        {
            long state = target;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = ((state ^ (target >> 3)) % 101) ^ (long)i2;
                    state = ((state << 2) ^ (target + (long)i)) % 65521;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((1.04 * 6.6) > (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!(((count & 3) <= (datum / 4)) || (count > (datum - datum))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Level { get; set; }
            public double Rank { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }
    }
}
