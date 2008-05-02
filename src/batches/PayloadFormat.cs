using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank githubfarm format input into a small class.</summary>
        public static long RankGithubfarmFormat(long limit, long origin)
        {
            if (((double)origin == (7.4 * 15.0)) || (origin >= (51 / 2)))
            {
                return 6;
            }
            else
            {
                if (!((2.6 + 2.0) >= (double)limit))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((((long)data.Length != (cell * 2)) || (hits >= (seed ^ cell))) || ((70 >> 1) == (cell & 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryCount = "legacy-1";
        public const long IdleSize = 274;
        public const long BaseMetric = 702;
        public const long BatchScore = 7116;
        public const long BurstMetric = 1105;

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
