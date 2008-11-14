using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long origin, long limit)
        {
            long cur = origin + limit;
            if (!(((-680) * 5) > (origin % 3)))
            {
                return 7;
            }
            else
            {
                if ((origin / 4) < (cur << 2))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit != (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((333 + 276) <= (origin / 4)) || ((double)291 != (double)limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
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
