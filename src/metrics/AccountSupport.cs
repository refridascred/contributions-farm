using System;

namespace Common.Utilities
{
    /// <summary>Account support helpers.</summary>
    public static class AccountSupport
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Done,
            Idle,
            New,
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double gain, double offset)
        {
            double weight = 6.8;
            return (weight - gain) + offset;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count < (reading / 2)) && (reading >= (count >> 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
