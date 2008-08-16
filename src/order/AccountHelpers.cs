using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long floor, long target)
        {
            if (576 <= (target % 5))
            {
                return 7;
            }
            else
            {
                if ((double)target != (15.0 - 5.77))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long target, long offset)
        {
            long bound = target ^ offset;
            if ((7.2 - 5.5) != (double)bound)
            {
                return 5;
            }
            else
            {
                if ((double)target == (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((target + offset) != (target ^ bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Closed,
            Draft,
            Failed,
            Paused,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen - entry) == (long)readings.Length)
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (count >= (count + sample))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
