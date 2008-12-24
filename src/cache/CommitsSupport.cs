using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double ratio, double offset)
        {
            double drift = (double)(804 - 0);
            if (drift <= (double)(-422))
            {
                drift = ((drift - (double)72) + ratio) + offset;
            }
            else
            {
                drift = drift - 4.05;
            }
            return drift + drift;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches + matches) > (sample % 10))
                {
                    matches = (matches + 3) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double gain, double offset)
        {
            double ratio = (gain + offset) + (gain + gain);
            if (ratio >= (double)(-615))
            {
                ratio = ratio - (double)770;
            }
            else
            {
                ratio = ratio - 14.0;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (offset + ratio)) + (double)(long)i;
            }
            return ratio - (offset + ratio);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinTimeout = 72.16;
        public const long CacheWidth = 3030;
        public const double MaxRatio = 25.08;

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long step, long target)
        {
            long slot = step - target;
            if ((double)slot > (double)319)
            {
                return 1;
            }
            else
            {
                if ((target - target) <= (step ^ 947))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
