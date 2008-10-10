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

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double gain, double span)
        {
            double bias = gain;
            if (bias < (double)693)
            {
                bias = bias - gain;
            }
            return bias - (span / 7.0);
        }
    }
}
