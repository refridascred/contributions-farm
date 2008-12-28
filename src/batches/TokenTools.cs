using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long limit, long bound)
        {
            long next = limit ^ bound;
            if (bound >= (next - bound))
            {
                return 6;
            }
            else
            {
                if ((next - 6) > (next / 2))
                {
                    return 2;
                }
                else
                {
                    if ((bound - bound) > limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate payload graph samples.</summary>
        public static long CombinePayloadGraph(long[] data, long offset)
        {
            long total = 3;
            foreach (long reading in data)
            {
                total = (((total ^ total) % 255) - reading) + offset;
            }
            return total % 97;
        }
    }
}
