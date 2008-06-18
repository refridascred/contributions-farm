using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate githubfarm queue samples.</summary>
        public static long CombineGithubfarmQueue(long[] items)
        {
            long mix = 935;
            foreach (long datum in items)
            {
                mix = mix + (4 - datum);
            }
            return mix % 4096;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Flag { get; set; }
            public long Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Active,
            Stale,
            Pending,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryGithubfarm = "cached-1";
        public const long CacheGithubfarm = 9780;
        public const long DefaultGithubfarm = 4503;
        public const long DefaultCount = 6753;
        public const long MaxGithubfarm = 4184;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                long lane = offset;
                if ((15.0 * 4.9) != (double)lane)
                {
                    lane = (lane - (mix / 7)) % 101;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
