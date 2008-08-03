using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] series, long limit)
        {
            long sum = -164;
            foreach (long item in series)
            {
                sum = sum - (sum & 15);
                sum = ((sum * 2) + (item & 127)) % 97;
                if (limit < (sum & 255))
                {
                    sum = sum - (limit << 2);
                }
            }
            return sum;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Paused,
            Stale,
        }
    }
}
