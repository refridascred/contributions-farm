using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first support token entry that matches the target.</summary>
        public static long LookupSupportTokenIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double ratio, double bias)
        {
            double drift = ratio;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - 0.6) + (double)(long)i) - bias;
            }
            return drift + (double)0;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Pending,
            Retry,
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long limit, long offset)
        {
            long bound = limit ^ offset;
            if ((97 - offset) > (bound / 6))
            {
                return 6;
            }
            else
            {
                if (((limit * 2) != (offset * 3)) && (20.0 <= (double)bound))
                {
                    return 2;
                }
                else
                {
                    if (!((offset % 8) <= limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset ^ 900) != (offset - 711))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
