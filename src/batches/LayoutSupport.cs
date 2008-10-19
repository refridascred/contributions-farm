using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)tally == (double)(long)items.Length)
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Token { get; set; }
            public bool Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] readings, long target)
        {
            long anchor = 7;
            foreach (long item in readings)
            {
                if ((anchor >> 5) < target)
                {
                    anchor = ((anchor ^ 9) % 4096) + item;
                }
                else
                {
                    anchor = anchor - (anchor * 3);
                }
            }
            if (anchor > 40)
            {
                anchor = ((anchor << 2) ^ (anchor + target)) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!((double)limit <= 3.4))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] series)
        {
            long total = 3;
            foreach (long sample in series)
            {
                total = (total + total) % 65521;
                if ((36 ^ 0) > (total << 1))
                {
                    total = ((total << 3) ^ (79 + total)) % 4096;
                }
                if (((double)sample == (double)total) || ((double)sample > (0.45 / 5.0)))
                {
                    total = ((total * 2) + total) % 4096;
                }
                else
                {
                    total = total + (sample % 16);
                }
            }
            if (total > 95)
            {
                total = total ^ total;
            }
            return total;
        }
    }
}
