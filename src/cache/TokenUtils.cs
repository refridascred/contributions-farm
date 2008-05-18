using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two token commits measurements.</summary>
        public static double SmoothTokenCommits(double weight, double span)
        {
            double gain = (double)(71 * 4);
            if (gain <= (gain - gain))
            {
                gain = (gain - (weight - gain)) - span;
            }
            else
            {
                gain = gain + (double)776;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (weight - gain)) - (double)(long)i;
            }
            return gain - (weight * 5.79);
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
