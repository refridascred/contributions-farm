using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Failed,
            Done,
            Retry,
        }

        /// <summary>Combine checks payload values into a single score.</summary>
        public static long ScoreChecksPayload(long[] samples)
        {
            long state = 71;
            foreach (long entry in samples)
            {
                state = ((state << 2) ^ state) + entry;
            }
            if (state > 92)
            {
                state = (state * 2) + (-1);
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheInterval = 4429;
        public const long DefaultWidth = 5844;
        public const double RetryGraph = 52.97;
        public const string MaxSize = "latest-v2";

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((target % 8) > (reading >> 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public bool Flag { get; set; }
            public bool Mode { get; set; }
        }
    }
}
