using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many token metrics samples are out of range.</summary>
        public static long AuditTokenMetricsMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((double)count <= (9.78 * 1.9)) && (((count ^ item) != (3 & 63)) || ((double)target < (6.2 / 8.0))))
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

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long origin, long offset)
        {
            long diff = origin + offset;
            if ((9.01 - 0.29) <= (double)offset)
            {
                return 3;
            }
            else
            {
                if (((double)offset >= 6.6) && ((origin - origin) >= (origin + diff)))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin > 1.1)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((diff & 7) <= 702) && ((double)origin == (3.6 * 3.79)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank record checks input into a small class.</summary>
        public static long GradeRecordChecks(long origin, long offset)
        {
            if ((origin * 4) >= (offset / 6))
            {
                return 1;
            }
            else
            {
                if ((origin * 4) >= (45 / 7))
                {
                    return 8;
                }
                else
                {
                    if (((double)offset != (3.0 / 9.0)) || ((8.0 / 4.0) >= (double)origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin - origin) < ((-52) >> 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheSize = 9809;
        public const long SoftDepth = 8537;
        public const long BaseRatio = 4241;
    }
}
