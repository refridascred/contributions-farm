using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 4) + result) % 1000;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Digest a series of layout counter entries.</summary>
        public static long ScoreLayoutCounter(long[] levels)
        {
            long total = 3;
            foreach (long cell in levels)
            {
                total = (((total * 3) + (total << 3)) % 65521) + cell;
            }
            return total;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Flag { get; set; }
            public bool Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
