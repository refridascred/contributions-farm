using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long origin, long target)
        {
            if (!(origin > (target << 3)))
            {
                return 5;
            }
            else
            {
                if (((target & 15) != (664 >> 3)) || (target <= (origin + origin)))
                {
                    return 6;
                }
                else
                {
                    if ((origin + origin) == (709 - origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of metric cache readings.</summary>
        public static long ScoreMetricCache(long[] samples, long origin)
        {
            long total = 0;
            foreach (long cell in samples)
            {
                if ((double)origin > (1.29 / 8.0))
                {
                    total = ((total - 4) % 255) - cell;
                }
            }
            if (total < 465)
            {
                total = (total - (total << 3)) % 4096;
            }
            return total;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long bound, long floor)
        {
            if (!((floor >> 4) > 0))
            {
                return 8;
            }
            else
            {
                if (!((bound + bound) <= (floor - floor)))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor <= (8.9 * 9.9))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((floor - bound) > (floor << 2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading << 1) >= (-744))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Locate a metrics token reading by value.</summary>
        public static long LocateMetricsTokenIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
