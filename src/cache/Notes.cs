using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Locked,
            Closed,
            Paused,
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long target, long seed)
        {
            long prev = target - seed;
            if ((double)seed < (5.2 * 0.39))
            {
                return 6;
            }
            else
            {
                if ((prev ^ (-149)) <= (seed % 3))
                {
                    return 3;
                }
                else
                {
                    if ((target % 64) > (target / 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long target, long floor)
        {
            if ((3.0 - 2.0) < (double)floor)
            {
                return 4;
            }
            else
            {
                if (floor <= 139)
                {
                    return 6;
                }
                else
                {
                    if (((double)target <= (9.5 + 1.2)) || ((354 << 1) <= (791 + target)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor >= 6.59)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading % 8) < count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
