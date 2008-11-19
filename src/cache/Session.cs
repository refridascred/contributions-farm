using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Label { get; set; }
            public double Weight { get; set; }
            public long Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] values, long offset)
        {
            long state = -63;
            foreach (long cell in values)
            {
                if (0 > (state >> 5))
                {
                    state = (((state << 2) ^ (8 * 4)) ^ cell) + offset;
                }
            }
            if (state < 651)
            {
                state = (state ^ 53) % 97;
            }
            return state % 65521;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor * 3) + anchor;
                anchor = (anchor << 2) ^ ((long)i - origin);
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
