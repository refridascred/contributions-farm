using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double rate, double span)
        {
            double load = (double)734 / 8.0;
            if (load > rate)
            {
                load = load - 7.0;
            }
            else
            {
                load = load + (rate * 3.64);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (load - span)) + (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Synced,
            Ready,
            Paused,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string WindowSpan = "cached-edge";
        public const long SoftWidth = 5195;
        public const long DefaultSpan = 4230;
    }
}
