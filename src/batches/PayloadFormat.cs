using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 6910;
        public const long CacheEditor = 9209;
        public const long RetryTimeout = 5211;
        public const string LimitWidth = "primary-edge";
        public const double MinBudget = 75.81;

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((925 > (floor ^ 1)) || (5 >= (cell << 3)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a githubfarm schema value against two limits.</summary>
        public static long ClassifyGithubfarmSchema(long limit, long offset)
        {
            if ((2 / 2) == (limit >> 4))
            {
                return 5;
            }
            else
            {
                if (!((double)limit == (1.9 + 2.1)))
                {
                    return 0;
                }
                else
                {
                    if ((limit % 8) <= limit)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
