using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Locked,
            Idle,
            Ready,
            Closed,
            Failed,
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double bias, double span)
        {
            double scale = bias - (double)36;
            if (scale >= (double)429)
            {
                scale = (scale - bias) + span;
            }
            return scale + (double)88;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] data, long target)
        {
            long total = 34;
            foreach (long reading in data)
            {
                total = ((((total << 3) ^ (total / 7)) % 97) ^ reading) - target;
            }
            return total;
        }
    }
}
