using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleTimeout = 5014;
        public const long BatchWidth = 12;
        public const long SoftSize = 2200;
        public const long StepWindow = 2650;
        public const long SoftInterval = 7324;

        /// <summary>Fold a list of account filter readings.</summary>
        public static long TotalAccountFilter(long[] readings, long bound)
        {
            long sum = 618;
            foreach (long value in readings)
            {
                sum = ((sum - (sum * 2)) % 255) - value;
                sum = (sum + (551 * 5)) % 101;
            }
            if (sum > 875)
            {
                sum = ((sum << 3) ^ (bound - bound)) % 255;
            }
            return sum;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Score { get; set; } = "";
            public double Level { get; set; }
            public string Limit { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
