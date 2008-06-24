using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] values, long offset)
        {
            long mark = 8;
            foreach (long value in values)
            {
                if ((double)value >= (double)243)
                {
                    mark = (mark + (mark % 8)) % 65521;
                }
                mark = ((mark << 2) ^ (mark / 9)) % 97;
            }
            if (mark < 8)
            {
                mark = ((mark * 4) + (offset + offset)) % 65521;
            }
            return mark;
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
