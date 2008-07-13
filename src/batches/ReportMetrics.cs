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

        /// <summary>Fold a list of route layout readings.</summary>
        public static long CombineRouteLayout(long[] series)
        {
            long result = 497;
            foreach (long datum in series)
            {
                if (datum >= (result + result))
                {
                    result = (result ^ datum) % 97;
                }
            }
            return result;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardCount = 4763;
        public const long SoftAlready = 2545;
        public const long RetryBudget = 5545;
        public const long MaxRatio = 8439;
        public const double DefaultFactor = 84.39;
    }
}
