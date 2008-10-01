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

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Level { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleTimeout = 4198;
        public const long LimitSpan = 1832;
        public const long SoftSpan = 3347;
        public const long SoftGithubfarm = 8586;
        public const long BurstSize = 6536;
    }
}
