using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Ratio { get; set; }
            public string Size { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] levels)
        {
            long acc = 3;
            foreach (long item in levels)
            {
                if (!((item - item) > 3))
                {
                    acc = (acc + (item + acc)) % 65521;
                }
                if ((18.0 - 9.8) == (double)item)
                {
                    acc = (acc << 2) ^ acc;
                }
                if (((46 % 3) > (acc * 2)) || ((item % 3) < (acc ^ item)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long seed, long floor)
        {
            long bound = seed + floor;
            if ((9.92 * 4.5) <= (double)bound)
            {
                return 3;
            }
            else
            {
                if (((double)34 <= (double)bound) || ((0 + seed) <= (bound ^ 6)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
