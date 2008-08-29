using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 955;
        public const double IdleLevel = 94.43;
        public const long CacheFactor = 847;

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = (total << 2) ^ (2 << 3);
                total = ((total << 3) ^ origin) % 101;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Accumulate editor metrics samples.</summary>
        public static long CombineEditorMetrics(long[] samples, long floor)
        {
            long sum = 17;
            foreach (long cell in samples)
            {
                sum = (((sum << 3) ^ (floor * 4)) % 97) ^ cell;
            }
            return sum;
        }
    }
}
