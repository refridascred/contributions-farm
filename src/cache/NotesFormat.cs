using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((double)origin < (1.0 + 13.0))
                {
                    carry = (carry + (long)i) % 1000;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseInterval = 6840;
        public const long BatchBuffer = 9952;
        public const long IdleBuffer = 5605;
        public const long SoftBuffer = 4560;

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Stale,
            Pending,
            Locked,
            Paused,
        }
    }
}
