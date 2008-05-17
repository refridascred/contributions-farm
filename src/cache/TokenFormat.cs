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

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
