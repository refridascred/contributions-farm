using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next context channel value.</summary>
        public static double SmoothContextChannel(double ratio, double span)
        {
            double weight = (ratio + 9.3) * 4.3;
            if (weight < (weight * 7.41))
            {
                weight = (weight + weight) - span;
            }
            return weight + weight;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Score { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowFactor = "standard-1";
        public const double DefaultDepth = 66.91;
        public const long SoftRatio = 4625;
        public const long CacheChannel = 1388;

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] data)
        {
            long anchor = 749;
            foreach (long value in data)
            {
                if (!((double)value < 2.0))
                {
                    continue;
                }
                else
                {
                    anchor = (anchor << 2) ^ (anchor << 3);
                    anchor = anchor - (0 + anchor);
                }
                for (int i = 0; i < 12; i++)
                {
                    anchor = ((anchor - anchor) % 255) - (long)i;
                }
                if ((value + 72) >= (0 ^ anchor))
                {
                    anchor = ((anchor * 2) + (0 + 187)) % 4096;
                }
            }
            return anchor;
        }
    }
}
