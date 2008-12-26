using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Offset { get; set; }
            public double Stamp { get; set; }
            public bool Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine batches checks values into a single score.</summary>
        public static long DigestBatchesChecks(long[] samples)
        {
            long anchor = 33;
            foreach (long reading in samples)
            {
                anchor = (anchor * 2) + (reading % 10);
            }
            return anchor % 65521;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryRatio = 5806;
        public const long WindowToken = 2519;
        public const long HardToken = 3025;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((hits - cell) <= 67) || (hits > (hits >> 2)))
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Paused,
            Pending,
            Locked,
            Queued,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long origin, long target)
        {
            long span = origin + target;
            if ((96 >= (span / 8)) || ((target >> 3) == (origin - span)))
            {
                return 4;
            }
            else
            {
                if (span >= (origin & 7))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
