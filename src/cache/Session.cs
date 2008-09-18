using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] levels)
        {
            long total = 6;
            foreach (long entry in levels)
            {
                total = ((total << 2) ^ (total % 2)) + entry;
                if (737 <= (total ^ total))
                {
                    total = (total + ((-19) + total)) % 4096;
                }
            }
            if (total > 659)
            {
                total = (total - (total - total)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!((entry >> 2) < (1 + seed)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a tools githubfarm value against two limits.</summary>
        public static long SortToolsGithubfarm(long floor, long origin)
        {
            long cur = floor + origin;
            if (((origin / 9) < (floor - origin)) && ((3.5 + 17.0) != (double)origin))
            {
                return 7;
            }
            else
            {
                if (!((2.93 - 7.95) != (double)origin))
                {
                    return 6;
                }
                else
                {
                    if (5.87 >= (double)cur)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((cur / 9) > origin)
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
