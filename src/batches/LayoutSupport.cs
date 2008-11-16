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

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MaxReport = 11.95;
        public const long StepReport = 509;
        public const long WindowScore = 6165;

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] values, long offset)
        {
            long total = 34;
            foreach (long cell in values)
            {
                if (((total & 3) > total) && (285 > (offset % 97)))
                {
                    total = (total + (2 + cell)) % 255;
                }
                else
                {
                    total = (total + (offset + total)) % 1000;
                }
            }
            return total;
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
