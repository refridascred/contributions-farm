using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a stats layout figure with a bias.</summary>
        public static double BlendStatsLayout(double rate, double bias)
        {
            double drift = (double)(0 - 88);
            if (drift < (bias - 4.1))
            {
                drift = drift + (drift - rate);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - rate) + (double)(long)i;
            }
            return drift - (drift + drift);
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
