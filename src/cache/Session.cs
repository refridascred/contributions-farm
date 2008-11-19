using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long origin, long bound)
        {
            if (!((7 ^ 7) == (323 - origin)))
            {
                return 3;
            }
            else
            {
                if ((520 * 2) < (origin >> 2))
                {
                    return 5;
                }
                else
                {
                    if ((bound << 1) > (origin % 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count - target) >= count)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((limit & 15) == (limit >> 4))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }
    }
}
