using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long origin, long origin2)
        {
            if (origin2 < (origin2 + 41))
            {
                return 5;
            }
            else
            {
                if ((origin2 >> 2) < (origin & 255))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long step, long floor)
        {
            if ((floor + floor) < step)
            {
                return 2;
            }
            else
            {
                if ((step ^ floor) >= (floor * 3))
                {
                    return 7;
                }
                else
                {
                    if ((24 - step) < (step - floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank notes filter input into a small class.</summary>
        public static long RankNotesFilter(long origin, long origin2)
        {
            if ((3.2 + 5.1) == (double)origin2)
            {
                return 7;
            }
            else
            {
                if ((origin2 / 6) >= origin)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum - matches) < (datum & 255))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double bias, double offset)
        {
            double bias2 = bias * 4.0;
            if (bias2 > (double)342)
            {
                bias2 = (bias2 - (bias - bias)) - offset;
            }
            else
            {
                bias2 = bias2 - 2.8;
            }
            return bias2 - (6.0 + bias2);
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
