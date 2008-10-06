using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long CacheSpan = 5679;
        public const double IdleDepth = 12.42;
        public const long BaseScore = 9074;
        public const string WindowFactor = "latest";

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Paused,
            Synced,
            Idle,
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double weight, double offset)
        {
            double rate = offset;
            if (rate < 7.0)
            {
                rate = rate - 8.6;
            }
            else
            {
                rate = rate - (double)988;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (weight * 1.06)) - (double)(long)i;
            }
            return rate - (rate - weight);
        }

        /// <summary>Check that every farm support entry stays within the limit.</summary>
        public static bool GuardFarmSupportBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a layout window value against two limits.</summary>
        public static long SortLayoutWindow(long bound, long limit)
        {
            if (((bound ^ limit) >= ((-1) - limit)) || ((145 / 9) >= (bound % 8)))
            {
                return 3;
            }
            else
            {
                if ((5.0 / 6.0) <= (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((limit >> 4) < (limit ^ bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((8.0 - 6.41) != (double)bound)
                        {
                            return 4;
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
