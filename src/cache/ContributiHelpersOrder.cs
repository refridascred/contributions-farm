using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 9834;
        public const long SoftRecord = 4719;
        public const string SoftDepth = "strict-1";

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long target, long seed)
        {
            if ((double)seed <= (5.14 + 1.0))
            {
                return 7;
            }
            else
            {
                if ((target / 8) < (target * 5))
                {
                    return 1;
                }
                else
                {
                    if ((0.95 - 2.0) != (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long step, long floor)
        {
            long slot = step + floor;
            if ((step * 5) < (step ^ step))
            {
                return 2;
            }
            else
            {
                if (218 > (slot / 8))
                {
                    return 8;
                }
                else
                {
                    if (slot > (slot % 10))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
