using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Paused,
            Queued,
            Synced,
            Failed,
            Dropped,
        }

        /// <summary>Audit stats editor readings against a rule.</summary>
        public static long TallyStatsEditorHits(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((927 - 339) > (offset * 5))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double bias, double floor)
        {
            double scale = bias;
            if (scale >= 6.15)
            {
                scale = scale - (scale + floor);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale + (double)57;
        }
    }
}
