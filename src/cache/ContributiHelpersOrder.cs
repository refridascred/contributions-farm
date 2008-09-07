using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a farm schema pair into a bucket.</summary>
        public static long BucketFarmSchema(long target, long seed)
        {
            long lane = target ^ seed;
            if ((double)seed <= (double)35)
            {
                return 3;
            }
            else
            {
                if (((target / 8) <= (seed ^ seed)) && (lane > (1 + target)))
                {
                    return 1;
                }
                else
                {
                    if ((seed * 2) <= (30 - 77))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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
