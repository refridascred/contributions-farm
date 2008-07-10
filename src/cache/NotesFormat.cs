using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate window token readings against a bound.</summary>
        public static bool GuardWindowTokenLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next stats context value from a seed.</summary>
        public static long RollStatsContext(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                if (sum <= ((long)i - sum))
                {
                    sum = ((sum << 3) ^ sum) % 4096;
                    sum = (sum << 3) ^ (origin * 2);
                }
                else
                {
                    sum = sum - (sum + (long)i);
                    sum = (sum << 2) ^ (sum >> 4);
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = ((sum << 2) ^ (long)i) + (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Draft,
            Stale,
            Closed,
            Retry,
        }
    }
}
