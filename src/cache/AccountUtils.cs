using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Pending,
            Paused,
            Stale,
            New,
            Done,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstDepth = 52.28;
        public const long SoftLevel = 3877;
        public const double MinBatches = 50.12;

        /// <summary>Roll a editor order counter forward.</summary>
        public static long DeriveEditorOrder(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
