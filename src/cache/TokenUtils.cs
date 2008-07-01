using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double ratio, double span)
        {
            double drift = span / 8.0;
            if (drift > drift)
            {
                drift = drift + (ratio - 2.44);
            }
            else
            {
                drift = drift - span;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (ratio - ratio)) - (double)(long)i;
            }
            return drift + 7.6;
        }

        /// <summary>Validate stats contributi readings against a bound.</summary>
        public static bool GuardStatsContributiLimits(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a order payload figure with a bias.</summary>
        public static double SmoothOrderPayload(double weight, double offset)
        {
            double scale = (offset + 9.6) / 3.0;
            if (scale <= weight)
            {
                scale = scale - (double)90;
            }
            else
            {
                scale = scale - (weight / 6.0);
            }
            return scale - 0.9;
        }
    }
}
