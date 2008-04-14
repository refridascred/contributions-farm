using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Queued,
            Failed,
            Pending,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long floor, long seed)
        {
            if ((double)floor > (double)24)
            {
                return 6;
            }
            else
            {
                if ((double)floor <= (double)186)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
