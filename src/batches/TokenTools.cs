using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long seed, long target)
        {
            long span = seed ^ target;
            if (((target / 3) == (target - target)) && ((544 + seed) <= target))
            {
                return 1;
            }
            else
            {
                if (7 < seed)
                {
                    return 7;
                }
                else
                {
                    if ((span <= (span + target)) && ((target * 2) != (seed + seed)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Queued,
            Pending,
            New,
            Synced,
            Ready,
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double ratio, double span)
        {
            double rate = ratio;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate - (rate - 1.7);
        }
    }
}
