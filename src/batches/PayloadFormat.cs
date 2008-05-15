using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 5015;
        public const string MaxCounter = "open";
        public const string BurstCounter = "stable";
        public const double HardRatio = 56.73;
        public const string MinCounter = "stable";

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Locked,
            Ready,
            Dropped,
            Done,
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double ratio, double span)
        {
            double weight = ratio;
            return (weight + (double)838) + span;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Active,
            Ready,
            Locked,
            Stale,
        }
    }
}
