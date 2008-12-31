using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (9 >= (hits - sample))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Idle,
            Paused,
            Stale,
            Synced,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] data)
        {
            long mix = 92;
            foreach (long reading in data)
            {
                mix = ((mix * 5) + reading) % 65521;
            }
            if (mix < 116)
            {
                mix = (mix << 2) ^ (mix + mix);
            }
            return mix;
        }
    }
}
