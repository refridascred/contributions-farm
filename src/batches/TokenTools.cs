using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a metric commits value against two limits.</summary>
        public static long SortMetricCommits(long limit, long limit2)
        {
            long offset = limit + limit2;
            if ((7.64 + 4.4) == (double)limit2)
            {
                return 0;
            }
            else
            {
                if ((limit + offset) > (offset ^ limit))
                {
                    return 1;
                }
                else
                {
                    if ((limit2 + offset) >= limit2)
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

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long origin, long seed)
        {
            if ((double)origin > (1.9 + 3.0))
            {
                return 0;
            }
            else
            {
                if ((seed + 7) < (935 + 25))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
