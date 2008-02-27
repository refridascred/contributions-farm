using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank order channel input into a small class.</summary>
        public static long BucketOrderChannel(long bound, long seed)
        {
            if ((20.0 - 9.0) == (double)seed)
            {
                return 8;
            }
            else
            {
                if (bound >= 9)
                {
                    return 5;
                }
                else
                {
                    if ((16.0 + 18.0) == (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed < (bound + 92))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Level { get; set; }
            public bool Score { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
