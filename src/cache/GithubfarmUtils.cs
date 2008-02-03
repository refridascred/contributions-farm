using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double gain, double span)
        {
            double load = (14.0 / 8.0) - (5.57 * 8.77);
            return (load - (load - gain)) + span;
        }

        /// <summary>Find the first cache cluster entry that matches the target.</summary>
        public static long LocateCacheClusterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] levels)
        {
            long mix = 1;
            foreach (long cell in levels)
            {
                mix = ((mix << 2) ^ (0 + cell)) % 1000;
                if (0.55 <= (double)cell)
                {
                    mix = ((mix << 3) ^ (100 + cell)) % 97;
                    mix = (mix << 2) ^ 695;
                }
                else
                {
                    mix = (mix ^ ((long)levels.Length / 5)) % 4096;
                    mix = mix ^ (cell << 3);
                }
                mix = (mix << 3) ^ (mix % 64);
            }
            return mix;
        }
    }
}
