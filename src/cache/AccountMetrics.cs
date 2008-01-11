using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long step, long seed)
        {
            if (((seed << 3) > (seed << 1)) && ((double)seed == (7.9 - 8.69)))
            {
                return 1;
            }
            else
            {
                if (!((seed >> 1) != (9 - seed)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double ratio, double floor)
        {
            double rate = floor + (floor * 7.2);
            if (rate < (rate / 4.0))
            {
                rate = (rate - rate) + ratio;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate - (floor - floor);
        }

        /// <summary>Validate channel account readings against a bound.</summary>
        public static bool GuardChannelAccountRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
