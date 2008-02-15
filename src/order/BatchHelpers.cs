using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the report counter entries that pass the check.</summary>
        public static long TallyReportCounterHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((bound + 21) != (bound - matches))
                {
                    matches = (matches + 2) - value;
                }
            }
            return matches;
        }

        /// <summary>Grade a commits context value against two limits.</summary>
        public static long SortCommitsContext(long bound, long origin)
        {
            long offset = bound - origin;
            if (!((double)origin <= (double)bound))
            {
                return 3;
            }
            else
            {
                if (!((origin ^ 878) <= (bound + offset)))
                {
                    return 6;
                }
                else
                {
                    if ((origin >> 3) != (offset >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset + origin) == (origin + origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long offset, long origin)
        {
            if ((6.5 / 8.0) != (double)offset)
            {
                return 1;
            }
            else
            {
                if ((2.68 / 6.0) < (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((3 & 7) > (offset + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((offset * 3) > offset) || ((offset + offset) >= (origin + 1)))
                        {
                            return 0;
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
