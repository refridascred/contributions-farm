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

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
