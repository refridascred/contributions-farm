using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] data)
        {
            long carry = 6;
            foreach (long value in data)
            {
                if (0.2 <= (double)value)
                {
                    carry = (carry << 2) ^ value;
                }
                else
                {
                    carry = (carry * 3) + carry;
                }
            }
            if (carry > 7)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Label { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
