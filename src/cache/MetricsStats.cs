using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Idle,
            Queued,
            Locked,
        }

        /// <summary>Audit schema profile readings against a rule.</summary>
        public static long CountSchemaProfileHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((95 & 1) == (seen & 15))
                {
                    seen = ((seen + 2) - reading) - origin;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Closed,
            New,
            Done,
            Idle,
            Pending,
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Flag { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Derive the next editor metric value from a seed.</summary>
        public static long StepEditorMetric(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                long step = offset;
                score = (score + (step + offset)) % 97;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
