using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Closed,
            Retry,
            Draft,
            Paused,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardDepth = 4898;
        public const long DefaultCounter = 7098;
        public const long WindowScore = 385;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Owner { get; set; }
            public double Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFilter = "stable-edge";
        public const long BatchWidth = 3637;
        public const double MinRatio = 5.97;
    }
}
