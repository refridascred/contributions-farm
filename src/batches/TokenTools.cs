using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] items, long floor)
        {
            long state = 0;
            foreach (long entry in items)
            {
                state = (state ^ entry) % 97;
                state = state - (entry << 3);
            }
            if (state > (-53))
            {
                state = ((state * 3) + (floor * 5)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Pending,
            New,
            Ready,
            Dropped,
        }
    }
}
