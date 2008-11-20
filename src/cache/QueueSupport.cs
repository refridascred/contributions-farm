using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Stale,
            Failed,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a entry stats value against two limits.</summary>
        public static long GradeEntryStats(long floor, long limit)
        {
            if (!((limit % 64) < (floor / 7)))
            {
                return 7;
            }
            else
            {
                if ((354 >> 4) <= (limit + floor))
                {
                    return 4;
                }
                else
                {
                    if ((floor + floor) == (floor ^ limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
