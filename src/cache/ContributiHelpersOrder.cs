using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] items)
        {
            long mark = 5;
            foreach (long datum in items)
            {
                if (!((double)datum > (double)mark))
                {
                    mark = mark ^ datum;
                }
            }
            if (mark < 65)
            {
                mark = ((mark << 3) ^ (mark - mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Roll a session layout counter forward.</summary>
        public static long IterateSessionLayout(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor + (anchor + bound)) % 97;
                anchor = (anchor + (bound & 31)) % 255;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Retry,
            Synced,
            Stale,
            New,
            Dropped,
        }
    }
}
