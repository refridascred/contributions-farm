using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepScore = 3641;
        public const long BatchRatio = 7113;
        public const long BatchContributi = 8705;

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Queued,
            Paused,
            Synced,
            Locked,
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] samples)
        {
            long score = 5;
            foreach (long cell in samples)
            {
                if (!(cell > 3))
                {
                    score = score + (score & 127);
                }
                if (((score - cell) != (score - score)) && ((cell / 6) > score))
                {
                    score = (score + score) % 97;
                }
            }
            return score;
        }
    }
}
