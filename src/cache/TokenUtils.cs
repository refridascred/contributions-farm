using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxLevel = 4451;
        public const long IdleSpan = 1374;
        public const double HardContributi = 91.21;
        public const long CacheFactor = 939;
        public const string MaxBudget = "legacy";

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] levels, long limit)
        {
            long result = -918;
            foreach (long value in levels)
            {
                result = (result + (limit * 2)) + value;
                result = result - (result + result);
            }
            return result;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] series, long offset)
        {
            long score = 66;
            foreach (long reading in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = ((score - ((long)i + score)) % 255) ^ reading;
                }
                if ((offset ^ 96) < offset)
                {
                    score = score - score;
                }
                else
                {
                    score = score - (offset % 2);
                }
            }
            return score;
        }
    }
}
