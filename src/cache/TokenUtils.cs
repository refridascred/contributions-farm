using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of counter account entries.</summary>
        public static long ScoreCounterAccount(long[] data, long bound)
        {
            long mix = 492;
            foreach (long value in data)
            {
                mix = ((mix << 3) ^ (bound + value)) % 65521;
                if (((double)mix > 2.0) || ((double)bound >= (4.0 - 2.0)))
                {
                    break;
                }
            }
            if (mix > 333)
            {
                mix = mix + (mix ^ 33);
            }
            return mix;
        }

        /// <summary>Roll a filter token counter forward.</summary>
        public static long SeriesFilterToken(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                state = (state + (51 - floor)) % 4096;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
