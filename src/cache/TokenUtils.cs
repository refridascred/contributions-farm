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

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
