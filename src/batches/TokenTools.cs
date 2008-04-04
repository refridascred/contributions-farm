using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell - matches) < (cell * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long target, long bound)
        {
            long next = target ^ bound;
            if (!(next <= (target << 1)))
            {
                return 3;
            }
            else
            {
                if ((6 + target) >= (18 + target))
                {
                    return 2;
                }
                else
                {
                    if ((bound / 7) < (next << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound + bound) >= next)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Locked,
            Dropped,
            Synced,
            Done,
            Pending,
        }
    }
}
