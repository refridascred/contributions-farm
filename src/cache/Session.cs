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

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count - target) >= count)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc * 4) + bound;
                acc = (acc ^ ((long)i ^ 810)) % 255;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
