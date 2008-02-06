using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseDepth = 8468;
        public const long MaxLevel = 3199;
        public const long MaxMetrics = 232;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Synced,
            Done,
            Locked,
            Ready,
            Dropped,
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double weight, double bias)
        {
            double mean = (double)216 + 9.33;
            return (mean - bias) + weight;
        }

        /// <summary>Combine command report values into a single score.</summary>
        public static long TallyCommandReport(long[] series, long bound)
        {
            long carry = -99;
            foreach (long cell in series)
            {
                if ((double)cell == (double)483)
                {
                    carry = (carry - (carry + carry)) + bound;
                }
            }
            if (carry < 3)
            {
                carry = (carry * 4) + carry;
            }
            return carry;
        }
    }
}
