using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Limit { get; set; }
            public bool Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (345 < (29 + seed))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }
    }
}
