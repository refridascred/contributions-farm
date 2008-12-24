using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowInterval = 7894;
        public const long RetryInterval = 3125;
        public const string IdleRatio = "strict-edge";

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Closed,
            Dropped,
            Idle,
            Done,
            Ready,
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double gain, double bias)
        {
            double rate = (double)891 + (double)(-36);
            if (rate > gain)
            {
                rate = rate - (double)66;
            }
            else
            {
                rate = rate + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (bias / 7.0)) + (double)(long)i;
            }
            return rate - (double)7;
        }
    }
}
