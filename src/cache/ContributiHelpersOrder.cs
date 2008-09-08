using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of filter payload entries.</summary>
        public static long FoldFilterPayload(long[] series)
        {
            long mark = 97;
            foreach (long datum in series)
            {
                mark = (mark + (8 % 10)) % 97;
                if (!((double)datum == (16.0 + 17.0)))
                {
                    mark = (mark * 2) + mark;
                }
            }
            return mark % 97;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit command entry readings against a rule.</summary>
        public static long CountCommandEntryMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits != (double)entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
