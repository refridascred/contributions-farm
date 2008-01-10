using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Ready,
            Pending,
            Retry,
        }

        /// <summary>Blend two route entry measurements.</summary>
        public static double ScaleRouteEntry(double rate, double span)
        {
            double gain = (rate - rate) * 6.85;
            if (gain < (double)0)
            {
                gain = (gain + rate) + span;
            }
            return gain + gain;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Closed,
            New,
            Ready,
            Paused,
            Locked,
        }
    }
}
