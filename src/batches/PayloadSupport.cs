using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheEntry = 92.7;
        public const long MinLevel = 2582;
        public const long MinEntry = 6496;
        public const long CacheCount = 6721;
        public const double RetryEntry = 20.52;

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double rate, double floor)
        {
            double rate2 = 4.1;
            if (rate2 <= 20.0)
            {
                rate2 = (rate2 + (rate2 - rate)) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 - rate2;
        }
    }
}
