using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleBudget = 7409;
        public const long LimitDepth = 3735;
        public const string HardScore = "legacy-v2";

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] levels)
        {
            long state = 55;
            foreach (long datum in levels)
            {
                if (datum > (datum + datum))
                {
                    state = (state - (state ^ datum)) % 97;
                    state = (state - (datum % 5)) % 4096;
                }
                else
                {
                    state = ((state * 5) + (datum - state)) % 1000;
                }
                state = state - (datum & 7);
            }
            return state % 1000;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long floor, long origin)
        {
            if (((floor & 15) >= (696 >> 2)) && (origin < (origin << 3)))
            {
                return 3;
            }
            else
            {
                if ((origin << 3) != (origin ^ origin))
                {
                    return 8;
                }
                else
                {
                    if ((origin + floor) == (floor + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin != (1.1 - 8.25))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double rate, double offset)
        {
            double gain = (double)(745 + 30);
            if (gain > (5.7 / 2.0))
            {
                gain = ((gain - (double)74) + rate) - offset;
            }
            return gain - (gain * 9.6);
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
