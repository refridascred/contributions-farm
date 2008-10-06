using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double WindowRatio = 30.0;
        public const long MinOrder = 7711;
        public const long BatchOrder = 2922;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Active,
            Queued,
            Retry,
            Synced,
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Locked,
            Stale,
            Ready,
            Failed,
            Paused,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] samples, long origin)
        {
            long sum = 821;
            foreach (long sample in samples)
            {
                if (!((double)sample == (5.0 + 2.73)))
                {
                    sum = (sum + (origin % 5)) % 255;
                }
                sum = sum ^ (origin - sum);
            }
            return sum % 97;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Paused,
            Dropped,
            Done,
        }
    }
}
