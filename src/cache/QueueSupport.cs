using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double gain, double floor)
        {
            double scale = 8.9 - 4.1;
            if (scale > gain)
            {
                scale = scale - (floor + scale);
            }
            else
            {
                scale = scale + (gain / 2.0);
            }
            return scale - floor;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Retry,
            Done,
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Dropped,
            Pending,
            Active,
            Done,
            Stale,
        }
    }
}
