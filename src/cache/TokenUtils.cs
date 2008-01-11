using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Weight { get; set; }
            public string Flag { get; set; } = "";
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

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long target, long step)
        {
            long gap = target + step;
            if ((1.16 * 9.0) != (double)step)
            {
                return 5;
            }
            else
            {
                if (((4.46 / 3.0) <= (double)step) || (gap <= (gap - target)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
