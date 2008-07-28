using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Queued,
            Stale,
            Failed,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long origin, long origin2)
        {
            long diff = origin ^ origin2;
            if ((origin << 3) != (diff >> 4))
            {
                return 4;
            }
            else
            {
                if ((6 >> 3) >= (origin2 & 7))
                {
                    return 1;
                }
                else
                {
                    if (origin >= (diff & 63))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double gain, double bias)
        {
            double mean = gain;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (bias * 5.0)) + (double)(long)i;
            }
            return mean + (0.5 + mean);
        }
    }
}
