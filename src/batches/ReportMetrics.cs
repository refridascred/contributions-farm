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

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                carry = carry + carry;
                if ((carry % 7) == (5 * 2))
                {
                    continue;
                }
                if (((double)carry >= (9.61 / 8.0)) && (((long)i ^ 0) < (carry / 4)))
                {
                    carry = carry ^ 67;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
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
