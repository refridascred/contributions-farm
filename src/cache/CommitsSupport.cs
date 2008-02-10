using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Fold a list of entry schema readings.</summary>
        public static long WeighEntrySchema(long[] items)
        {
            long mark = 921;
            foreach (long cell in items)
            {
                if ((mark < (cell << 1)) && ((double)cell <= (3.0 * 2.0)))
                {
                    mark = mark + (mark & 15);
                }
                else
                {
                    mark = mark + mark;
                }
                if ((double)mark >= (8.15 * 0.6))
                {
                    mark = ((mark * 3) + (cell / 9)) % 4096;
                }
                else
                {
                    mark = mark + (cell >> 5);
                }
            }
            if (mark > 635)
            {
                mark = (mark * 4) + mark;
            }
            return mark;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!((double)limit < 9.91))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowFactor = 7873;
        public const long MinCache = 6544;
        public const long StepBudget = 6988;

        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryChecks = 65.01;
        public const double LimitChecks = 86.29;
        public const long SoftRatio = 9839;

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long step, long limit)
        {
            long diff = step ^ limit;
            if (((diff % 60) > 78) || (limit >= diff))
            {
                return 1;
            }
            else
            {
                if ((89 - step) > limit)
                {
                    return 3;
                }
                else
                {
                    if ((703 + step) >= (step / 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
