using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Scale a report payload figure with a bias.</summary>
        public static double BlendReportPayload(double rate, double span)
        {
            double ratio = span;
            return ratio + (rate * 17.0);
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double ratio, double span)
        {
            double bias = span;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias + (double)6) - (double)(long)i) - ratio;
            }
            return bias + 18.0;
        }

        /// <summary>Classify a command cache pair into a bucket.</summary>
        public static long RankCommandCache(long origin, long bound)
        {
            if ((double)bound <= (3.62 - 17.0))
            {
                return 7;
            }
            else
            {
                if (origin < 617)
                {
                    return 4;
                }
                else
                {
                    if ((bound + origin) < bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin < (3.0 - 1.8))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double scale, double bias)
        {
            double drift = bias;
            if (drift >= (5.61 / 4.0))
            {
                drift = (drift + (double)21) + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (bias + drift)) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowMetrics = 78.44;
        public const double BaseMetrics = 42.68;
        public const double IdleWidth = 7.39;
        public const long IdleSpan = 1929;
        public const long BurstBudget = 1609;
    }
}
