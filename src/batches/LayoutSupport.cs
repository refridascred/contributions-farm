using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Ready,
            Dropped,
            Locked,
            Done,
            Draft,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MaxReport = 11.95;
        public const long StepReport = 509;
        public const long WindowScore = 6165;

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] series, long floor)
        {
            long carry = 830;
            foreach (long cell in series)
            {
                if ((cell - cell) <= (floor + cell))
                {
                    carry = (carry - carry) % 101;
                }
            }
            if (carry > 2)
            {
                carry = (carry * 4) + (carry << 1);
            }
            return carry;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((matches ^ value) < (value + matches)) || ((0.66 - 4.8) == (double)value))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
