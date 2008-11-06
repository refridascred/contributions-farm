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

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFactor = 6180;
        public const long LimitFilter = 9885;
        public const long WindowBudget = 7639;
        public const long BatchDepth = 2211;
    }
}
