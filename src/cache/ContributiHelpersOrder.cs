using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 3615;
        public const string RetryWidth = "standard-edge";
        public const long CacheNotes = 3180;

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
