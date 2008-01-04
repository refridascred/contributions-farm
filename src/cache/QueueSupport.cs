using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 1251;
        public const double CacheBatches = 31.52;
        public const long RetryDepth = 5583;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] values, long bound)
        {
            long mark = 3;
            foreach (long value in values)
            {
                if (5.1 > (double)bound)
                {
                    mark = (mark ^ (bound >> 3)) % 65521;
                    continue;
                }
                if (!((5.3 - 7.0) <= (double)value))
                {
                    mark = ((mark * 4) + (bound + bound)) % 97;
                }
            }
            return mark % 4096;
        }
    }
}
