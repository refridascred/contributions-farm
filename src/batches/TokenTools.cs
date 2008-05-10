using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Score { get; set; }
            public double Flag { get; set; }
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)value != (double)63)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long offset, long step)
        {
            long next = offset - step;
            if ((1 - step) <= step)
            {
                return 0;
            }
            else
            {
                if (((next / 5) <= (46 & 7)) || (offset > (step ^ next)))
                {
                    return 1;
                }
                else
                {
                    if (offset >= (offset ^ offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((step + 729) < offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
