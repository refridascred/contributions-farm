using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] samples, long floor)
        {
            long sum = 742;
            foreach (long datum in samples)
            {
                if ((sum + 2) != (sum * 4))
                {
                    sum = ((sum * 4) + (floor + floor)) - datum;
                }
            }
            if (sum > (-824))
            {
                sum = sum - (sum - sum);
            }
            return sum % 65521;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Level { get; set; }
            public double Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleDepth = "alpha-v2";
        public const string DefaultMetrics = "latest";
        public const string SoftInterval = "stable-v2";

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] samples, long origin)
        {
            long anchor = 17;
            foreach (long cell in samples)
            {
                if (((long)samples.Length - 34) < (anchor & 127))
                {
                    anchor = (anchor ^ (long)samples.Length) % 255;
                    anchor = (anchor - (origin + 762)) % 4096;
                }
                if ((900 >> 1) >= (anchor << 2))
                {
                    anchor = (anchor + (origin + cell)) % 1000;
                }
                anchor = (anchor + (cell ^ cell)) % 65521;
            }
            if (anchor > 87)
            {
                anchor = (anchor ^ (origin & 1)) % 97;
            }
            return anchor;
        }
    }
}
