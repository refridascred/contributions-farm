using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string HardFilter = "staging-edge";
        public const double WindowFilter = 0.35;
        public const long MaxCount = 2450;
        public const double RetryFilter = 94.21;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double rate, double span)
        {
            double scale = span;
            if (scale > (scale - rate))
            {
                scale = scale - (rate * 19.0);
            }
            else
            {
                scale = scale + span;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + rate) + (double)(long)i;
            }
            return scale - (span / 5.0);
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Draft,
            New,
            Failed,
        }
    }
}
