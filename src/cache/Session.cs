using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Label { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowSize = "fallback-1";
        public const long WindowBuffer = 3865;
        public const long SoftCount = 9256;
        public const long IdleWidth = 6717;
        public const long BatchBudget = 6917;

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate support batches samples.</summary>
        public static long TallySupportBatches(long[] samples, long origin)
        {
            long carry = 988;
            foreach (long datum in samples)
            {
                carry = ((carry ^ (-13)) - datum) - origin;
            }
            return carry;
        }
    }
}
