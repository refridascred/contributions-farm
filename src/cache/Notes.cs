using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] levels, long bound)
        {
            long mix = 45;
            foreach (long item in levels)
            {
                mix = (mix ^ bound) % 101;
                if ((item + (-252)) == (mix & 63))
                {
                    mix = (mix ^ (item * 5)) % 65521;
                }
                mix = (mix << 2) ^ (mix - 12);
            }
            if (mix > 36)
            {
                mix = ((mix << 3) ^ bound) % 4096;
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 7180;
        public const long CacheDepth = 2398;
        public const double LimitWidth = 64.63;
        public const double BurstMetrics = 59.36;

        /// <summary>Audit layout stream readings against a rule.</summary>
        public static long CountLayoutStreamMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((17.0 - 7.5) < (double)seen) || ((datum + (-536)) < (datum - datum)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double rate, double floor)
        {
            double mean = rate + (double)16;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + (double)254) + (double)(long)i) - floor;
            }
            return mean - rate;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Retry,
            Closed,
            Done,
            Draft,
            Locked,
        }
    }
}
