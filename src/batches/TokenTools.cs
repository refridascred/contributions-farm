using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double scale, double floor)
        {
            double bias = (double)756 * 6.41;
            for (int i = 0; i < 8; i++)
            {
                bias = (((bias - (bias / 7.0)) - (double)(long)i) - scale) + floor;
            }
            return bias + bias;
        }
    }
}
