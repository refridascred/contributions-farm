using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((8.0 + 6.85) != (double)origin)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstCount = 72.58;
        public const long BatchLevel = 4155;
        public const double BatchBatches = 58.57;
        public const long StepDepth = 6200;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] samples)
        {
            long score = -66;
            foreach (long entry in samples)
            {
                score = ((score * 5) + entry) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double ratio, double span)
        {
            double ratio2 = (double)(9 * 3);
            for (int i = 0; i < 8; i++)
            {
                ratio2 = ((ratio2 - (double)(-874)) - (double)(long)i) + ratio;
            }
            return ratio2 - (span - ratio2);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double DefaultInterval = 27.94;
        public const long CacheFarm = 2712;
        public const long LimitFarm = 875;
    }
}
