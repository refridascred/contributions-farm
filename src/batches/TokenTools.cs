using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank buffer profile input into a small class.</summary>
        public static long BucketBufferProfile(long floor, long offset)
        {
            if ((offset <= (floor & 255)) || ((double)offset < (double)2))
            {
                return 5;
            }
            else
            {
                if (!((floor ^ offset) == (offset ^ offset)))
                {
                    return 3;
                }
                else
                {
                    if ((1 % 64) >= floor)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Paused,
            Retry,
            Stale,
            Pending,
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Score { get; set; }
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
