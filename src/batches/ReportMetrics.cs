using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long origin, long limit)
        {
            if (!((limit & 31) < (origin & 3)))
            {
                return 1;
            }
            else
            {
                if ((double)limit == (2.5 + 4.0))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] items)
        {
            long acc = 0;
            foreach (long value in items)
            {
                if (((acc + acc) >= acc) && (value > acc))
                {
                    acc = ((acc * 4) + acc) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long origin, long floor)
        {
            if (((double)origin == (20.0 * 8.2)) && ((floor & 3) < origin))
            {
                return 3;
            }
            else
            {
                if (((floor >> 1) > origin) && ((double)floor >= (double)(-626)))
                {
                    return 4;
                }
                else
                {
                    if (origin < (origin >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if (floor >= (floor + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
