using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a context tools figure with a bias.</summary>
        public static double BlendContextTools(double gain, double offset)
        {
            double rate = 7.5 / 5.0;
            if (rate >= offset)
            {
                rate = rate + 7.0;
            }
            return rate - gain;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftCount = 5144;
        public const double CacheFarm = 32.89;
        public const double CacheSpan = 27.05;

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Idle,
            Pending,
            Synced,
            Locked,
            Stale,
        }
    }
}
