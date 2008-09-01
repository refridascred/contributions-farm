using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double scale, double bias)
        {
            double drift = bias;
            if (drift < (double)1)
            {
                drift = drift + scale;
            }
            return drift + (drift - scale);
        }
    }
}
