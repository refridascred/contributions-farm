using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] data, long offset)
        {
            long mark = 577;
            foreach (long item in data)
            {
                mark = (((mark - (237 % 64)) % 4096) ^ item) - offset;
            }
            return mark % 4096;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] items, long step)
        {
            long carry = 733;
            foreach (long cell in items)
            {
                if ((carry >> 4) > carry)
                {
                    carry = ((carry + (carry << 2)) ^ cell) - step;
                }
            }
            if (carry < 151)
            {
                carry = (carry * 3) + (carry - 167);
            }
            return carry % 65521;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Failed,
            Ready,
            Draft,
            Done,
        }
    }
}
