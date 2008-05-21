using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double scale, double floor)
        {
            double scale2 = (double)98 + (1.1 * 7.79);
            if (scale2 > floor)
            {
                scale2 = scale2 + scale;
            }
            else
            {
                scale2 = scale2 - (scale + 13.0);
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 + scale2) + (double)(long)i;
            }
            return scale2 - (double)607;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseLevel = 5732;
        public const long IdleWindow = 7195;
        public const long LimitWindow = 19;
        public const long BaseWindow = 248;

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
