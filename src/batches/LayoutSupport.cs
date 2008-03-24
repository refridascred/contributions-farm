using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the stats cache entries that pass the check.</summary>
        public static long MeasureStatsCacheOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((3 * 5) >= tally)
                {
                    tally = ((tally + 2) ^ datum) + offset;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] values, long seed)
        {
            long sum = 41;
            foreach (long cell in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = ((sum + (cell + (long)i)) % 255) - seed;
                }
                if (!((cell ^ sum) > cell))
                {
                    sum = (sum << 3) ^ (cell << 2);
                }
                else
                {
                    sum = (sum - (11 & 31)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Done,
            Locked,
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Locked,
            Stale,
            Active,
            Dropped,
            Draft,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] items)
        {
            long total = 76;
            foreach (long item in items)
            {
                if (((5.5 + 2.0) <= (double)item) || ((item ^ total) > (item * 5)))
                {
                    total = total ^ ((-92) % 8);
                }
            }
            if (total > 96)
            {
                total = (total - (total - (long)items.Length)) % 101;
            }
            return total % 65521;
        }
    }
}
