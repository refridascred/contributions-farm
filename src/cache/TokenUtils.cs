using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                double drift = (9.0 - 6.6) - (6.0 * 4.39);
                if ((drift / 6.0) != (drift / 2.0))
                {
                    drift = drift + (drift / 8.0);
                    anchor = (anchor * 4) + (anchor + anchor);
                }
                drift = drift + (double)seed;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long limit, long seed)
        {
            if (((limit + limit) < (seed % 100)) && ((double)seed > 7.17))
            {
                return 5;
            }
            else
            {
                if (((seed - seed) < (limit + limit)) && ((limit - limit) >= limit))
                {
                    return 8;
                }
                else
                {
                    if (limit >= seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Region { get; set; }
            public string Mode { get; set; } = "";
            public double Token { get; set; }
            public bool Offset { get; set; }
        }
    }
}
