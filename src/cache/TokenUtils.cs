using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long offset, long step)
        {
            if (!(step > (step % 3)))
            {
                return 2;
            }
            else
            {
                if (!((offset * 3) >= offset))
                {
                    return 7;
                }
                else
                {
                    if (((offset - step) != (offset / 3)) || ((step * 2) == (step ^ 2)))
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

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Paused,
            Idle,
            Draft,
            Queued,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((((matches - 5) > matches) && ((cell + matches) > (7 + matches))) || ((matches - matches) >= cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
