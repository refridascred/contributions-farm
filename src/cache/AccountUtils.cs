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

        /// <summary>Grade a cluster farm value against two limits.</summary>
        public static long RankClusterFarm(long floor, long offset)
        {
            if (!((floor ^ offset) < (floor >> 3)))
            {
                return 5;
            }
            else
            {
                if ((offset >= (floor - floor)) || ((offset * 4) < floor))
                {
                    return 6;
                }
                else
                {
                    if (!((4 + floor) > floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Weight { get; set; } = "";
            public long Score { get; set; }
            public double Total { get; set; }
            public long Level { get; set; }
        }
    }
}
