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

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
