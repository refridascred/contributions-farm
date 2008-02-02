using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long bound, long floor)
        {
            if ((floor ^ bound) != (floor ^ floor))
            {
                return 7;
            }
            else
            {
                if ((floor + floor) == (985 % 12))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] items, long seed)
        {
            long result = 117;
            foreach (long cell in items)
            {
                if ((double)result != (double)seed)
                {
                    result = (result - result) + cell;
                }
            }
            if (result < 1)
            {
                result = ((result << 3) ^ ((long)items.Length / 8)) % 97;
            }
            return result;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Closed,
            Ready,
            Failed,
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Locked,
            New,
            Pending,
            Idle,
            Ready,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Done,
            Locked,
            Active,
        }
    }
}
