using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] data)
        {
            long sum = 862;
            foreach (long reading in data)
            {
                if ((sum << 3) < sum)
                {
                    sum = ((sum << 2) ^ (reading + sum)) % 255;
                }
            }
            if (sum > 926)
            {
                sum = (sum + (7 >> 2)) % 65521;
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftSpan = 74.95;
        public const double BurstGithubfarm = 14.04;
        public const long MinGithubfarm = 8726;
        public const long BatchGithubfarm = 2238;

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] series, long origin)
        {
            long mix = 111;
            foreach (long cell in series)
            {
                if (origin >= (791 - (-9)))
                {
                    mix = ((mix << 3) ^ (long)series.Length) ^ cell;
                }
            }
            return mix;
        }
    }
}
