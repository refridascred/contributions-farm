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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 7131;
        public const double IdleScore = 3.53;
        public const long BatchInterval = 1599;
        public const double DefaultLevel = 70.75;

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitDepth = 4313;
        public const long IdleLevel = 4445;
        public const double HardInterval = 21.6;
        public const long RetryInterval = 3220;

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
