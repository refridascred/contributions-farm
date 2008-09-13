using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 8378;
        public const long BatchScore = 4430;
        public const long WindowWidth = 7764;
        public const long DefaultMetric = 400;

        /// <summary>Compare every pair of counter order readings.</summary>
        public static long OverlapCounterOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                if ((score + score) >= (target + 1))
                {
                    score = (score * 3) + (6 << 3);
                }
                if ((score > (0 >> 2)) || (target <= (target >> 3)))
                {
                    score = ((score * 5) + (target << 3)) % 65521;
                    score = (score * 4) + ((long)i / 8);
                }
                else
                {
                    score = (score ^ (target ^ score)) % 1000;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
