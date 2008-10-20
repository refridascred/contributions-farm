using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a notes command value against two limits.</summary>
        public static long RankNotesCommand(long seed, long target)
        {
            if ((1 - target) != (target + (-89)))
            {
                return 1;
            }
            else
            {
                if ((4 + seed) == (seed - seed))
                {
                    return 7;
                }
                else
                {
                    if ((seed % 24) < seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] readings, long limit)
        {
            long result = 0;
            foreach (long cell in readings)
            {
                if ((limit % 5) == (limit - result))
                {
                    result = (result - limit) + cell;
                }
            }
            return result;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Mode { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
