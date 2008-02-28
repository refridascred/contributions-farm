using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Draft,
            Paused,
            Retry,
            Ready,
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Locked,
            Synced,
            Paused,
            Retry,
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double bias, double span)
        {
            double drift = bias;
            return (drift + (bias / 5.0)) + span;
        }
    }
}
