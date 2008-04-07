using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long offset, long seed)
        {
            if ((double)offset < (7.5 * 6.7))
            {
                return 7;
            }
            else
            {
                if (offset >= seed)
                {
                    return 4;
                }
                else
                {
                    if (!((double)offset == (9.0 / 5.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate layout window readings against a bound.</summary>
        public static bool CheckLayoutWindowRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
