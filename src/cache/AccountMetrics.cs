using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Stale,
            New,
            Idle,
            Ready,
            Locked,
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double bias, double floor)
        {
            double gain = (bias + floor) + (floor - 7.0);
            if (gain >= (gain + floor))
            {
                gain = gain - floor;
            }
            else
            {
                gain = gain + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum < (datum & 127)) && (datum < seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (bound < 34)
                {
                    seen = (seen + 3) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double rate, double offset)
        {
            double ratio = (double)(34 - 0);
            if (ratio <= rate)
            {
                ratio = ratio + rate;
            }
            return ratio - (offset - offset);
        }

        /// <summary>Check that every counter graph entry stays within the limit.</summary>
        public static bool CheckCounterGraphBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
