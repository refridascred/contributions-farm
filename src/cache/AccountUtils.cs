using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up farm entry samples.</summary>
        public static long MatchFarmEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Done,
            Synced,
            Idle,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] readings, long origin)
        {
            long total = 51;
            foreach (long cell in readings)
            {
                if ((cell / 3) >= (574 + origin))
                {
                    total = total - ((-96) % 16);
                }
                else
                {
                    total = (total ^ (912 << 2)) % 65521;
                }
            }
            if (total > (-97))
            {
                total = total + (origin >> 3);
            }
            return total % 97;
        }
    }
}
