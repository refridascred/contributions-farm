using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long offset, long origin)
        {
            if (((-1) % 64) >= origin)
            {
                return 6;
            }
            else
            {
                if (2.77 < (double)offset)
                {
                    return 2;
                }
                else
                {
                    if ((offset - offset) >= (origin + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset + (-69)) < (origin + origin)) && ((origin - offset) != (offset >> 4)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public long Label { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
