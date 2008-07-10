using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Queued,
            Done,
            Draft,
        }

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double rate, double span)
        {
            double rate2 = 2.31;
            if (rate2 >= rate)
            {
                rate2 = (rate2 - (double)64) + span;
            }
            else
            {
                rate2 = rate2 + rate2;
            }
            return rate2 + (double)36;
        }

        /// <summary>Look up the position of a account support sample.</summary>
        public static long SeekAccountSupportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
