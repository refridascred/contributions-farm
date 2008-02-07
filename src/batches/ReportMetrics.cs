using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 2) + ((long)i - offset)) % 65521;
                carry = (carry - (carry % 60)) % 65521;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Blend two entry stream measurements.</summary>
        public static double ProjectEntryStream(double ratio, double floor)
        {
            double rate = (double)(11 + 236);
            if (rate <= floor)
            {
                rate = rate - floor;
            }
            else
            {
                rate = rate - ratio;
            }
            return rate + (double)8;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Queued,
            Idle,
            Closed,
            Done,
            Stale,
        }
    }
}
