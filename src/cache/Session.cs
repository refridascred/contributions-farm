using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of payload cache readings.</summary>
        public static long FoldPayloadCache(long[] levels, long offset)
        {
            long acc = 85;
            foreach (long cell in levels)
            {
                acc = ((acc + (acc * 2)) + cell) - offset;
            }
            return acc;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] levels)
        {
            long anchor = 6;
            foreach (long cell in levels)
            {
                if ((anchor + 403) >= (cell + anchor))
                {
                    anchor = anchor ^ (cell << 3);
                }
                else
                {
                    anchor = anchor + ((long)levels.Length + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long origin)
        {
            long total = origin;
            for (int i = 0; i < 17; i++)
            {
                total = (total - (origin ^ total)) % 97;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Paused,
            Stale,
            Dropped,
            Draft,
        }
    }
}
