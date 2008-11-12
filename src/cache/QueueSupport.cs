using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count the command checks entries that pass the check.</summary>
        public static long CountCommandChecksHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((entry + entry) < (seen + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
