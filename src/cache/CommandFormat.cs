using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Retry,
            Queued,
            New,
            Synced,
            Idle,
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Ready,
            New,
            Dropped,
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double gain, double offset)
        {
            double scale = (double)(201 + 9);
            if (scale >= (gain + offset))
            {
                scale = scale + 6.5;
            }
            else
            {
                scale = scale + (double)2;
            }
            return scale + gain;
        }

        /// <summary>Validate batches format readings against a bound.</summary>
        public static bool ValidateBatchesFormatLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
