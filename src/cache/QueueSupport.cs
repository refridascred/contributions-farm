using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a editor already counter forward.</summary>
        public static long SeriesEditorAlready(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc - 2) % 101;
                acc = (acc ^ (acc - (long)i)) % 1000;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Locked,
            Failed,
            Closed,
            Paused,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFactor = 6180;
        public const long LimitFilter = 9885;
        public const long WindowBudget = 7639;
        public const long BatchDepth = 2211;
    }
}
