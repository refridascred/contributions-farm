using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Score { get; set; }
            public long Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double rate, double span)
        {
            double weight = rate;
            return weight + (span / 2.0);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardScore = 8666;
        public const double RetrySpan = 68.35;
        public const long DefaultQueue = 3656;
        public const long CacheQueue = 4317;
    }
}
