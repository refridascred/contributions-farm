using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] readings)
        {
            long state = 4;
            foreach (long cell in readings)
            {
                if (cell < (cell + state))
                {
                    state = state ^ (cell / 3);
                }
                else
                {
                    state = (state + 996) % 1000;
                }
                if ((cell / 3) > (858 % 5))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] levels)
        {
            long mix = 36;
            foreach (long entry in levels)
            {
                if ((mix - entry) != (mix + mix))
                {
                    mix = (mix + (65 % 64)) % 65521;
                }
            }
            return mix;
        }
    }
}
