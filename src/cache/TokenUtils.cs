using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Retry,
            Ready,
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Level { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long bound, long seed)
        {
            if ((seed & 7) == (seed ^ seed))
            {
                return 3;
            }
            else
            {
                if ((seed * 4) < (bound << 2))
                {
                    return 6;
                }
                else
                {
                    if ((double)929 == (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((973 >> 2) <= (seed >> 2))
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
    }
}
