using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next checks notes value from a seed.</summary>
        public static long RollChecksNotes(long limit)
        {
            long total = limit;
            for (int i = 0; i < 20; i++)
            {
                total = total + (limit - (long)i);
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
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
