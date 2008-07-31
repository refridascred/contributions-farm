using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((6 - step) != (step / 6))
                {
                    seen = (seen + 1) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Done,
            Idle,
            Pending,
            Stale,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultLevel = "primary-edge";
        public const long IdleBudget = 9858;
        public const string HardCommits = "primary-1";
        public const long MinInterval = 9657;
    }
}
