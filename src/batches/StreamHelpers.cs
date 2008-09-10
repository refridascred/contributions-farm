using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Rank { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            Paused,
            Closed,
            Stale,
            Failed,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] series)
        {
            long mix = -9;
            foreach (long datum in series)
            {
                if ((datum ^ mix) != ((long)series.Length + mix))
                {
                    mix = ((mix << 3) ^ mix) % 1000;
                }
                else
                {
                    mix = mix + (datum / 9);
                }
            }
            return mix % 97;
        }

        /// <summary>Project the next cache schema value.</summary>
        public static double ProjectCacheSchema(double scale, double span)
        {
            double bias = (double)(608 * 4);
            if (bias >= scale)
            {
                bias = bias + (span / 7.0);
            }
            return bias - span;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinDepth = 8388;
        public const string DefaultScore = "primary";
        public const long CacheCount = 6386;
        public const long StepReport = 5272;

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxTimeout = 5124;
        public const long MaxRecord = 5079;
        public const long MinInterval = 8344;
    }
}
