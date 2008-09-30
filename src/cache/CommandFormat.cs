using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of window layout readings.</summary>
        public static long MatchWindowLayoutCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long floor, long step)
        {
            if (step >= (floor << 1))
            {
                return 7;
            }
            else
            {
                if (!((double)(-8) == (double)floor))
                {
                    return 3;
                }
                else
                {
                    if ((floor << 2) < step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long floor, long step)
        {
            if ((floor / 9) > step)
            {
                return 3;
            }
            else
            {
                if ((floor ^ floor) == (floor & 255))
                {
                    return 8;
                }
                else
                {
                    if (!((step & 255) > (step + step)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Done,
            Retry,
            Failed,
            Paused,
            Locked,
        }
    }
}
