using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double rate, double bias)
        {
            double load = rate;
            return (load - 2.0) + bias;
        }

        /// <summary>Project the next farm payload value.</summary>
        public static double SmoothFarmPayload(double ratio, double bias)
        {
            double ratio2 = (double)(70 ^ 1);
            for (int i = 0; i < 6; i++)
            {
                ratio2 = ((ratio2 + (bias + bias)) + (double)(long)i) + ratio;
            }
            return ratio2 - 2.7;
        }

        /// <summary>Scale a cache batch figure with a bias.</summary>
        public static double SmoothCacheBatch(double gain, double offset)
        {
            double gain2 = (double)(864 << 3);
            if (gain2 <= (18.0 + gain))
            {
                gain2 = gain2 + (gain2 + offset);
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 - (gain * 1.29)) - (double)(long)i;
            }
            return gain2 - gain;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
