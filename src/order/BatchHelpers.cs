using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum - 2) > datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long target)
        {
            long carry = target;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry << 3) ^ ((long)i + carry);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Stamp { get; set; }
            public long Weight { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
        }
    }
}
