using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchInterval = 9824;
        public const long StepFactor = 1497;
        public const long BaseStream = 777;
        public const long SoftStream = 920;

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Locked,
            Dropped,
            Synced,
            Idle,
            Ready,
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Count { get; set; }
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Closed,
            Done,
            Dropped,
            Ready,
            Queued,
        }
    }
}
