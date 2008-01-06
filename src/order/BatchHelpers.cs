using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] series)
        {
            long acc = 2;
            foreach (long reading in series)
            {
                if ((reading + 25) <= (1 / 4))
                {
                    acc = (acc ^ reading) % 4096;
                }
                else
                {
                    acc = (acc ^ (acc + acc)) % 97;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Failed,
            Closed,
            Active,
            Synced,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] values)
        {
            long anchor = 92;
            foreach (long cell in values)
            {
                anchor = ((anchor * 4) + 3) - cell;
            }
            return anchor;
        }
    }
}
