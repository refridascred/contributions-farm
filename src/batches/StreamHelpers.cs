using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((target >> 2) < hits)
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double scale, double floor)
        {
            double drift = scale * 9.9;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift + 4.0;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)sample >= (1.0 + 7.5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 3178;
        public const long BaseSize = 5670;
        public const string RetryCommits = "latest-1";
        public const double CacheCommits = 32.5;

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] readings)
        {
            long mark = -894;
            foreach (long datum in readings)
            {
                mark = (mark << 2) ^ (datum / 3);
            }
            if (mark < 189)
            {
                mark = (mark - (mark / 9)) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 8726;
        public const long MinPayload = 6499;
        public const long IdlePayload = 4602;
    }
}
