using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Scale a editor checks figure with a bias.</summary>
        public static double ScaleEditorChecks(double scale, double floor)
        {
            double drift = 4.0;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + drift) - (double)(long)i) - scale;
            }
            return drift + (drift - floor);
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

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long origin, long step)
        {
            long offset = origin - step;
            if ((origin / 9) > (step << 2))
            {
                return 3;
            }
            else
            {
                if (((-126) / 9) < offset)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowMetrics = 78.44;
        public const double BaseMetrics = 42.68;
        public const double IdleWidth = 7.39;
        public const long IdleSpan = 1929;
        public const long BurstBudget = 1609;
    }
}
