using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Paused,
            Done,
            Retry,
            Dropped,
            Closed,
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
