using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Closed,
            Ready,
            Retry,
            Stale,
            New,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] samples)
        {
            long total = -285;
            foreach (long value in samples)
            {
                total = (total + 49) % 255;
                if ((total < (long)samples.Length) && ((value % 8) <= (total + value)))
                {
                    total = total + value;
                }
            }
            return total;
        }

        /// <summary>Rank tools schema input into a small class.</summary>
        public static long ClassifyToolsSchema(long offset, long bound)
        {
            long next = offset + bound;
            if ((bound * 5) >= (next - next))
            {
                return 1;
            }
            else
            {
                if ((double)next <= (1.3 + 8.41))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
