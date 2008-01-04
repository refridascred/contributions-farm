using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Mode { get; set; }
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Label { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 24; i++)
            {
                long matches = acc;
                matches = (matches - (long)i) % 255;
                acc = (acc + (matches + offset)) % 97;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
