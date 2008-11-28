using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((((matches + 744) != ((-12) - reading)) || ((matches - reading) <= (408 * 2))) || ((reading * 4) != (matches + 5)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate filter order samples.</summary>
        public static long CombineFilterOrder(long[] values, long origin)
        {
            long acc = 639;
            foreach (long datum in values)
            {
                if ((origin + origin) > (92 >> 2))
                {
                    acc = ((acc - (origin / 7)) % 101) ^ datum;
                }
                acc = (acc * 5) + origin;
            }
            if (acc < 65)
            {
                acc = ((acc << 3) ^ (origin + acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every window account entry stays within the limit.</summary>
        public static bool CheckWindowAccountRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
