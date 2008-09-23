using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] readings)
        {
            long carry = 44;
            foreach (long item in readings)
            {
                carry = (carry << 2) ^ 614;
                if ((45 + item) <= (item ^ carry))
                {
                    carry = carry ^ (carry / 4);
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Paused,
            Closed,
            Draft,
            Stale,
        }
    }
}
