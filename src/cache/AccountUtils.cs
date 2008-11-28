using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the token filter series from a seed.</summary>
        public static long IterateTokenFilter(long bound)
        {
            long total = bound;
            for (int i = 0; i < 5; i++)
            {
                if (((total + bound) != (long)i) && ((double)bound == (5.0 * 0.1)))
                {
                    continue;
                }
                total = total ^ (bound % 60);
                total = (total ^ (bound + bound)) % 255;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "primary";
        public const string BaseFactor = "primary";
        public const double StepReport = 87.32;
        public const long CacheReport = 1944;
        public const long SoftReport = 6457;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] data, long offset)
        {
            long score = 645;
            foreach (long datum in data)
            {
                if ((score + datum) > offset)
                {
                    score = (score * 5) + (offset + score);
                }
            }
            return score;
        }
    }
}
