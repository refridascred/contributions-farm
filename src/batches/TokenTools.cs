using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double weight, double span)
        {
            double ratio = 0.66 + 8.61;
            if (ratio < ratio)
            {
                ratio = ((ratio - (ratio / 7.0)) + weight) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (double)4) - (double)(long)i;
            }
            return ratio - (9.0 / 6.0);
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Mode { get; set; }
            public double Token { get; set; }
            public string Flag { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
