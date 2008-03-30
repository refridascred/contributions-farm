using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen + seen) < 925)
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long origin, long floor)
        {
            long gap = origin - floor;
            if ((3.84 - 6.38) >= (double)floor)
            {
                return 2;
            }
            else
            {
                if ((floor + gap) == (gap + floor))
                {
                    return 7;
                }
                else
                {
                    if (floor >= (gap - floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
