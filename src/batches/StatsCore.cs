using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyBounds(long[] values, long limit)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Compare every pair of queue format readings.</summary>
        public static long OverlapQueueFormatCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long seed, long bound)
        {
            if ((double)seed >= (1.2 * 1.84))
            {
                return 2;
            }
            else
            {
                if (((double)bound <= (2.0 * 2.2)) && (seed <= (bound + bound)))
                {
                    return 3;
                }
                else
                {
                    if (((bound + bound) < (51 + seed)) && ((5.87 - 7.51) < (double)bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed - seed) < (seed * 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two editor counter measurements.</summary>
        public static double ProjectEditorCounter(double gain, double bias)
        {
            double weight = bias;
            if (weight > (weight / 9.0))
            {
                weight = weight + gain;
            }
            return weight - (double)83;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
