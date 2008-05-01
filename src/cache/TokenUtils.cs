using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long offset, long floor)
        {
            if ((floor % 7) > (floor >> 1))
            {
                return 2;
            }
            else
            {
                if (offset < (floor + floor))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Level { get; set; } = "";
            public bool Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long bound, long origin)
        {
            if ((origin / 3) < origin)
            {
                return 7;
            }
            else
            {
                if ((7.07 + 2.0) >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((origin + origin) < (origin + bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((2.0 - 1.4) != (double)origin)
                        {
                            return 2;
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
