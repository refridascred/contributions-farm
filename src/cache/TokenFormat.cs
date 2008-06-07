using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitChannel = 57.78;
        public const long CacheRatio = 8188;
        public const double LimitCount = 45.42;

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double bias, double floor)
        {
            double mean = (bias / 9.0) - bias;
            if (mean <= (double)9)
            {
                mean = mean + (floor - mean);
            }
            else
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + 6.5) + (double)(long)i;
            }
            return mean + (bias + 9.66);
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
