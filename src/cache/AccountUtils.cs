using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            New,
            Done,
            Draft,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((step ^ value) > (count / 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
