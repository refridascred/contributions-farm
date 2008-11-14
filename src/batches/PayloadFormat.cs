using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits < 9.4)
                {
                    hits = ((hits + 1) + sample) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] series, long bound)
        {
            long acc = -941;
            foreach (long sample in series)
            {
                acc = ((acc - acc) % 255) - sample;
                acc = acc - bound;
                acc = (acc ^ (bound & 31)) % 4096;
            }
            if (acc > 302)
            {
                acc = (acc + (bound + acc)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
            public long Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 5633;
        public const double DefaultBatch = 36.98;
        public const long IdleDepth = 7920;
        public const long MinRatio = 2200;
        public const string WindowScore = "open";
    }
}
