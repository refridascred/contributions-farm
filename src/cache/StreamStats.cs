using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 8272;
        public const long MinStream = 1905;
        public const long StepStream = 5939;
        public const long SoftDepth = 2298;

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Stale,
            New,
            Queued,
            Failed,
            Locked,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!(0 > (hits / 6)))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }
    }
}
