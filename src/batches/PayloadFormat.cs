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

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
