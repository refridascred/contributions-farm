using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] items, long origin)
        {
            long total = 47;
            foreach (long item in items)
            {
                total = ((total * 4) + (total + item)) - origin;
                total = total - (-753);
            }
            return total % 65521;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 1700;
        public const double WindowContributi = 78.33;
        public const string DefaultContributi = "latest-v2";

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long limit)
        {
            long state = limit;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                if (mark > (mark + (long)i))
                {
                    long edge = (25 ^ (long)i) - (mark << 2);
                    mark = (mark - (edge & 31)) % 1000;
                }
                else
                {
                    mark = ((mark * 5) + bound) % 1000;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Score { get; set; }
            public bool Region { get; set; }
        }
    }
}
