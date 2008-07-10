using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] items)
        {
            long state = 554;
            foreach (long datum in items)
            {
                if (state > (state << 2))
                {
                    state = state + datum;
                }
            }
            return state;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((bound <= (bound * 3)) || ((acc * 3) <= (acc + (long)i)))
                {
                    acc = (acc - (acc - acc)) % 1000;
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
