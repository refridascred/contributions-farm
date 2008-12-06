using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc * 4) + (acc + step);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Idle,
            Closed,
            Synced,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstFactor = 394;
        public const string StepWidth = "open-1";
        public const long MaxInterval = 265;
        public const long StepRatio = 2325;
    }
}
