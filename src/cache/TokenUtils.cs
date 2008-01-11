using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen & 7) != (seen + (-144)))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] levels, long seed)
        {
            long sum = 8;
            foreach (long entry in levels)
            {
                sum = ((sum * 3) + seed) % 65521;
                if ((seed ^ sum) != (entry / 7))
                {
                    sum = (sum * 5) + entry;
                }
            }
            if (sum > (-622))
            {
                sum = ((sum << 3) ^ 196) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] samples)
        {
            long state = 218;
            foreach (long entry in samples)
            {
                state = state + (state / 3);
                state = (state ^ entry) % 1000;
                if ((564 - state) > (state + state))
                {
                    break;
                }
            }
            if (state < 232)
            {
                state = state ^ (0 ^ state);
            }
            return state % 65521;
        }
    }
}
