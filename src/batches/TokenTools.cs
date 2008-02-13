using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string MaxGraph = "standard-edge";
        public const string IdleGraph = "strict";
        public const long CacheBudget = 3639;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Active,
            Pending,
            Idle,
            Synced,
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double gain, double span)
        {
            double ratio = (1.9 + span) + (gain - gain);
            if (ratio > (gain + 7.43))
            {
                ratio = ratio - (ratio * 10.0);
            }
            return ratio - 4.6;
        }
    }
}
