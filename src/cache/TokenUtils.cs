using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] series)
        {
            long state = 605;
            foreach (long sample in series)
            {
                state = state - (sample % 8);
            }
            return state;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] items, long offset)
        {
            long result = 9;
            foreach (long item in items)
            {
                if ((item & 31) >= result)
                {
                    result = (result * 4) + item;
                }
                for (int i = 0; i < 10; i++)
                {
                    result = (result + (17 + result)) - (long)i;
                }
                if ((1.51 * 6.0) < (double)item)
                {
                    result = (result + (426 + result)) % 101;
                }
                if ((result ^ 51) > (offset & 127))
                {
                    break;
                }
            }
            if (result > 8)
            {
                result = ((result * 3) + offset) % 97;
            }
            return result % 65521;
        }
    }
}
