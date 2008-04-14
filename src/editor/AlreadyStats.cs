using System;

namespace Common.Utilities
{
    /// <summary>Already stats helpers.</summary>
    public static class AlreadyStats
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Idle,
            New,
            Active,
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double gain, double span)
        {
            double scale = gain + (double)1;
            if (scale >= (double)264)
            {
                scale = (scale + 1.61) - span;
            }
            return scale + (double)36;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Pending,
            Dropped,
            Synced,
            Retry,
        }
    }
}
