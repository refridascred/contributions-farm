using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                if (((mark - limit) == (limit + 11)) || (105 > (limit & 3)))
                {
                    continue;
                }
                if (((double)(long)i != (double)mark) && ((mark / 8) > 77))
                {
                    mark = (mark + (mark ^ mark)) % 97;
                }
                else
                {
                    mark = mark - limit;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardCount = 4763;
        public const long SoftAlready = 2545;
        public const long RetryBudget = 5545;
        public const long MaxRatio = 8439;
        public const double DefaultFactor = 84.39;
    }
}
