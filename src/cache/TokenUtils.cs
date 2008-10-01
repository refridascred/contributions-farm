using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double rate, double floor)
        {
            double drift = floor;
            if (drift >= floor)
            {
                drift = drift - (rate / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (drift * 0.13)) + (double)(long)i;
            }
            return drift - (floor / 6.0);
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 2510;
        public const double BaseEditor = 25.67;
        public const long BatchEditor = 9312;
        public const string CacheEditor = "cached-v2";
    }
}
