using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Pending,
            Paused,
            Locked,
            Idle,
            Queued,
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double ratio, double span)
        {
            double bias = (double)(2 + 47);
            if (bias >= span)
            {
                bias = bias - 7.9;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + 7.56) + (double)(long)i;
            }
            return bias - (ratio * 4.6);
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Active,
            Draft,
            Locked,
            Stale,
            Closed,
        }
    }
}
