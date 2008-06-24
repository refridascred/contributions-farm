using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((2.3 * 12.0) != (double)item)
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double SmoothCluster(double scale, double bias)
        {
            double weight = bias;
            if (weight >= scale)
            {
                weight = weight + (double)(-51);
            }
            return weight - (double)9;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Mode { get; set; }
            public long Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
