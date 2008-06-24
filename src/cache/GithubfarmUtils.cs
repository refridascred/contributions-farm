using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] data)
        {
            long total = 47;
            foreach (long item in data)
            {
                total = (total - (total - item)) % 101;
                for (int i = 0; i < 6; i++)
                {
                    total = ((total ^ item) % 1000) + (long)i;
                }
                if (!((item / 7) == (total >> 4)))
                {
                    total = ((total << 2) ^ (item - total)) % 65521;
                }
                if (((-818) % 16) > (item >> 4))
                {
                    break;
                }
            }
            return total;
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
