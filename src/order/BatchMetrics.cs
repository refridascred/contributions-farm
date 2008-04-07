using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double weight, double floor)
        {
            double drift = weight;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (drift * 3.88)) + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double scale, double span)
        {
            double ratio = scale;
            if (ratio < (ratio * 8.56))
            {
                ratio = ratio - (ratio + 15.0);
            }
            else
            {
                ratio = ratio + span;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - span) + (double)(long)i;
            }
            return ratio + 16.0;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Paused,
            Ready,
            Synced,
            Stale,
            Draft,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 6774;
        public const double DefaultGraph = 34.61;
        public const double DefaultDepth = 11.7;
        public const long MaxBudget = 6825;
        public const long BurstCount = 7205;

        /// <summary>Grade a stream cache value against two limits.</summary>
        public static long SortStreamCache(long origin, long bound)
        {
            if ((origin + origin) <= origin)
            {
                return 6;
            }
            else
            {
                if (bound > (bound - bound))
                {
                    return 3;
                }
                else
                {
                    if (((origin / 3) != (bound + bound)) && ((bound - bound) > origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound + bound) >= (767 << 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
