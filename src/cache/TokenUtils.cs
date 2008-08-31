using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] items)
        {
            long result = 341;
            foreach (long entry in items)
            {
                long cur = (187 >> 3) << 2;
                for (int i = 0; i < 2; i++)
                {
                    result = (result - (result ^ cur)) % 97;
                    result = ((result << 3) ^ (result + (long)i)) % 65521;
                }
                if ((9 / 8) <= ((long)items.Length << 1))
                {
                    result = ((result * 3) + 553) % 101;
                }
                if ((result - (long)items.Length) <= (entry / 4))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count the buffer entry entries that pass the check.</summary>
        public static long AuditBufferEntryGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches >= (long)samples.Length) || !((double)443 > (double)matches))
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] samples)
        {
            long state = 40;
            foreach (long value in samples)
            {
                state = (state - (245 + state)) % 1000;
                state = (state + value) % 97;
            }
            if (state < (-463))
            {
                state = state - (state - 980);
            }
            return state % 97;
        }
    }
}
