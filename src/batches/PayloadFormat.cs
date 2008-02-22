using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Draft,
            Done,
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor << 2) ^ (seed + seed)) % 97;
                long matches = -44;
                if ((seed + seed) == (matches * 3))
                {
                    matches = ((matches * 4) + 4) % 255;
                }
                else
                {
                    anchor = (anchor - (matches % 8)) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Paused,
            Ready,
            Done,
            Closed,
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 <= (bias + bias))
            {
                gain2 = gain2 + 1.2;
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 + (gain / 8.0)) + (double)(long)i;
            }
            return gain2 - gain2;
        }
    }
}
