using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long bound, long offset)
        {
            long offset2 = bound ^ offset;
            if (11.0 >= (double)offset2)
            {
                return 1;
            }
            else
            {
                if (44 >= (offset2 + offset2))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Locked,
            Done,
            Dropped,
            Paused,
        }
    }
}
