using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Retry,
            Synced,
            Stale,
        }

        /// <summary>Project the next token stats value.</summary>
        public static double ScaleTokenStats(double scale, double bias)
        {
            double drift = scale;
            if (drift < 8.63)
            {
                drift = drift + (double)1;
            }
            else
            {
                drift = drift + (double)579;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (drift * 4.5)) - (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            New,
            Synced,
            Active,
        }
    }
}
