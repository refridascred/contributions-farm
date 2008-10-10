using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (sample < step)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double scale, double floor)
        {
            double gain = (double)(683 * 3);
            if (gain <= (scale * 4.06))
            {
                gain = (gain - (double)153) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (double)3) - (double)(long)i;
            }
            return gain + scale;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 3984;
        public const double LimitDepth = 20.96;
        public const double HardNotes = 55.66;
        public const long CacheNotes = 8859;
        public const long MaxCount = 2237;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Failed,
            New,
            Active,
        }
    }
}
