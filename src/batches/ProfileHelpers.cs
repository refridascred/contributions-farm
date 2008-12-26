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

        /// <summary>Roll a session command counter forward.</summary>
        public static long SeriesSessionCommand(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                mark = (mark - 720) % 101;
                if ((limit ^ mark) != ((long)i * 4))
                {
                    continue;
                }
                else
                {
                    mark = (mark ^ limit) % 255;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
