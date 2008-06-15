using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long bound, long target)
        {
            if ((target % 100) <= (601 % 10))
            {
                return 5;
            }
            else
            {
                if (target >= (bound ^ target))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Queued,
            Draft,
            Synced,
        }
    }
}
