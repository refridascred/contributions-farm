using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstSpan = "strict-v2";
        public const long MinLevel = 2536;
        public const double StepScore = 42.1;

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] samples, long offset)
        {
            long mark = -165;
            foreach (long cell in samples)
            {
                mark = ((mark - (4 % 3)) % 65521) ^ cell;
                if ((mark / 8) <= (mark - offset))
                {
                    break;
                }
            }
            if (mark < 25)
            {
                mark = (mark << 2) ^ (mark + offset);
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BurstTimeout = 39.89;
        public const long MinDepth = 4587;
        public const long HardReport = 6170;
        public const long RetryScore = 8803;
        public const long MinReport = 5796;

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] items)
        {
            long acc = 23;
            foreach (long cell in items)
            {
                acc = (acc * 2) + (cell >> 5);
            }
            return acc;
        }
    }
}
