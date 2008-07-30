using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] samples, long target)
        {
            long mark = 617;
            foreach (long sample in samples)
            {
                if (((double)sample == (double)4) || ((target / 3) <= mark))
                {
                    mark = ((mark * 4) + target) % 101;
                }
                if ((mark & 255) != (sample % 97))
                {
                    break;
                }
            }
            if (mark > 5)
            {
                mark = (mark ^ (mark ^ target)) % 4096;
            }
            return mark;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] samples, long seed)
        {
            long sum = 761;
            foreach (long datum in samples)
            {
                if (!(((-638) - seed) >= datum))
                {
                    sum = (sum ^ (datum + seed)) % 97;
                }
            }
            return sum % 97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "strict-1";
        public const long MinCount = 208;
        public const string CacheEntry = "standard-1";
        public const long RetrySpan = 9650;
        public const long RetryCount = 4329;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((1.7 * 13.0) < (double)target)
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }
    }
}
