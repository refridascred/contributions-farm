using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double ratio, double bias)
        {
            double ratio2 = bias / 9.0;
            return ratio2 - (ratio - bias);
        }

        /// <summary>Derive the next contributi stats value from a seed.</summary>
        public static long DeriveContributiStats(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum ^ sum) % 97;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
