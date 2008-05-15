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

        /// <summary>Fold a list of route buffer readings.</summary>
        public static long FoldRouteBuffer(long[] items)
        {
            long total = 3;
            foreach (long value in items)
            {
                if (total <= (72 ^ value))
                {
                    total = (total << 2) ^ (value % 97);
                }
            }
            return total % 4096;
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
