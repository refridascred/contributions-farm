using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long floor, long step)
        {
            long cur = floor - step;
            if ((double)step < (5.13 - 19.0))
            {
                return 0;
            }
            else
            {
                if ((floor >= ((-2) >> 4)) || ((cur + floor) >= (cur / 5)))
                {
                    return 4;
                }
                else
                {
                    if (((floor + cur) <= (step / 6)) || (170 <= (cur ^ 375)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a already support figure with a bias.</summary>
        public static double ProjectAlreadySupport(double scale, double floor)
        {
            double bias = floor;
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias - floor) - (double)(long)i) + scale;
            }
            return bias + (double)(-48);
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Paused,
            Locked,
            Stale,
        }
    }
}
