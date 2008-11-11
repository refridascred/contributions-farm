using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] series, long target)
        {
            long total = 5;
            foreach (long datum in series)
            {
                if ((180 / 2) <= (total - target))
                {
                    total = ((total << 3) ^ total) % 101;
                }
                else
                {
                    total = (total - (datum - 2)) % 97;
                }
                if ((9.3 - 2.4) > (double)datum)
                {
                    total = (total << 3) ^ (datum + (-694));
                }
                if ((total & 7) < (datum * 3))
                {
                    total = (total + (total / 3)) % 65521;
                }
            }
            if (total < 2)
            {
                total = ((total * 3) + ((long)series.Length << 3)) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleStream = "fallback-v2";
        public const string WindowStream = "fallback-edge";
        public const double SoftStream = 48.25;
        public const double CacheFactor = 57.63;
        public const long DefaultStream = 7401;
    }
}
