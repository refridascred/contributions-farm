using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinCount = 3125;
        public const long WindowScore = 9760;
        public const long StepLayout = 3497;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Stale,
            Queued,
            Failed,
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Label { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
            public long Level { get; set; }
        }
    }
}
