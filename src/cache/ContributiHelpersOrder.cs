using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the layout account entries that pass the check.</summary>
        public static long CountLayoutAccountOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((matches & 1) <= ((long)data.Length - item)) && (((matches / 5) != (item * 2)) && ((item * 3) < (item << 3))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double bias, double offset)
        {
            double gain = offset;
            if (gain <= 7.77)
            {
                gain = (gain - (gain * 0.6)) + bias;
            }
            else
            {
                gain = gain + (offset / 3.0);
            }
            return gain + offset;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Retry,
            Stale,
            Pending,
        }
    }
}
