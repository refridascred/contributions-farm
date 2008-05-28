using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            New,
            Queued,
            Paused,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinSize = 2411;
        public const string SoftGithubfarm = "fallback-v2";
        public const long HardTimeout = 7371;

        /// <summary>Fold a list of queue cluster readings.</summary>
        public static long WeighQueueCluster(long[] items, long floor)
        {
            long sum = -728;
            foreach (long sample in items)
            {
                sum = ((sum << 3) ^ (sample ^ 97)) % 4096;
                for (int i = 0; i < 2; i++)
                {
                    sum = (sum << 2) ^ (sample % 64);
                    sum = sum - (long)i;
                }
                sum = sum ^ (639 - floor);
            }
            if (sum > 478)
            {
                sum = (sum - (sum & 3)) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of graph entry entries.</summary>
        public static long WeighGraphEntry(long[] series)
        {
            long total = 47;
            foreach (long sample in series)
            {
                if (!(sample > (sample >> 3)))
                {
                    total = (total ^ total) % 101;
                }
            }
            if (total < 614)
            {
                total = (total + ((-8) % 2)) % 65521;
            }
            return total % 4096;
        }
    }
}
