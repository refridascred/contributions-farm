using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Dropped,
            Paused,
            Done,
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Closed,
            Dropped,
            Ready,
        }

        /// <summary>Blend two graph cluster measurements.</summary>
        public static double BlendGraphCluster(double gain, double bias)
        {
            double gain2 = (bias - 0.6) - bias;
            if (gain2 > (double)2)
            {
                gain2 = gain2 - 1.5;
            }
            else
            {
                gain2 = gain2 - gain2;
            }
            return gain2 + (gain * 19.0);
        }
    }
}
