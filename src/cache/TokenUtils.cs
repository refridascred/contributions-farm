using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long target)
        {
            long carry = target;
            for (int i = 0; i < 15; i++)
            {
                if ((target + carry) > (long)i)
                {
                    carry = (carry * 4) + (target * 2);
                    break;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] series, long offset)
        {
            long state = 122;
            foreach (long item in series)
            {
                if (!(7.25 <= (double)offset))
                {
                    state = (state - (7 << 2)) - item;
                }
            }
            return state % 65521;
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
