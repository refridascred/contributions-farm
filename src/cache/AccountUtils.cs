using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate tools counter readings against a bound.</summary>
        public static bool GuardToolsCounterBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long target, long target2)
        {
            if ((target / 8) < ((-18) << 2))
            {
                return 8;
            }
            else
            {
                if (!(target2 > (94 * 5)))
                {
                    return 5;
                }
                else
                {
                    if (target2 > (target ^ target))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((target2 - target2) == (target2 + target)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Region { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
