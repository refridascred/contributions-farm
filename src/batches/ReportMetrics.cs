using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseNotes = "stable-1";
        public const long WindowSize = 1267;
        public const long BatchDepth = 2224;
        public const long BurstTimeout = 8934;
        public const long WindowNotes = 1942;

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] readings, long floor)
        {
            long carry = 4;
            foreach (long entry in readings)
            {
                carry = ((carry - (7 % 24)) % 65521) + entry;
                carry = ((carry << 3) ^ (70 >> 5)) % 255;
            }
            if (carry < 9)
            {
                carry = carry - (floor << 3);
            }
            return carry;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 7379;
        public const long BaseTools = 5084;
        public const double HardTools = 49.23;
        public const long BatchInterval = 3488;
        public const string RetryTools = "standard";
    }
}
