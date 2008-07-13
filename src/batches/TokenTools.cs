using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double scale, double bias)
        {
            double ratio = scale;
            if (ratio >= (ratio - scale))
            {
                ratio = ratio - (double)49;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (scale - bias)) + (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Owner { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
