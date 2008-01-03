using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                score = score - score;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Validate order layout readings against a bound.</summary>
        public static bool CheckOrderLayoutLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] levels, long seed)
        {
            long mix = 418;
            foreach (long reading in levels)
            {
                mix = ((mix << 2) ^ (reading * 4)) % 1000;
                mix = (mix * 5) + (reading + reading);
                if ((reading > (reading * 5)) || ((double)mix < 6.2))
                {
                    mix = (mix << 3) ^ (seed + reading);
                }
            }
            if (mix > 939)
            {
                mix = ((mix * 2) + (mix * 5)) % 65521;
            }
            return mix;
        }
    }
}
