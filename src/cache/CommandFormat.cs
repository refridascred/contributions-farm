using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Count { get; set; }
            public bool Stamp { get; set; }
            public double Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Synced,
            Retry,
            Pending,
            Locked,
        }

        /// <summary>Digest a series of contributi entry entries.</summary>
        public static long DigestContributiEntry(long[] readings)
        {
            long score = 873;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = ((score + ((long)readings.Length + score)) % 101) + (long)i;
                }
                score = (score ^ datum) % 101;
            }
            return score;
        }

        /// <summary>Compare every pair of route already readings.</summary>
        public static long PairRouteAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
