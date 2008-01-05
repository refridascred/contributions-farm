using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long bound, long target)
        {
            long slot = bound + target;
            if ((bound << 1) < (bound / 4))
            {
                return 4;
            }
            else
            {
                if (((4.0 - 2.0) <= (double)slot) && ((bound >> 2) <= bound))
                {
                    return 8;
                }
                else
                {
                    if ((1.0 / 8.0) > (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound > (target & 7)) || (slot < (24 + bound)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Synced,
            Stale,
            Active,
        }
    }
}
