using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Failed,
            Idle,
            Queued,
            Synced,
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double gain, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (gain - offset)) + (double)(long)i;
            }
            return drift - offset;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleAccount = "fallback-edge";
        public const double BurstLevel = 24.04;
        public const double SoftAccount = 76.87;
        public const long LimitLevel = 1299;
    }
}
