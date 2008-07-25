using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 8; i++)
            {
                carry = carry - (bound * 3);
                carry = ((carry << 3) ^ carry) % 97;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((145 << 3) >= (floor + 5))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
