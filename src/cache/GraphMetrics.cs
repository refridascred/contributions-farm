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

        /// <summary>Define session limits and defaults.</summary>
        public const string BaseScore = "strict-edge";
        public const long LimitBudget = 1320;
        public const long StepDepth = 7632;
        public const long BatchCount = 768;

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
