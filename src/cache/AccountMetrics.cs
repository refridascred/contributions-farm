using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] samples, long seed)
        {
            long total = 891;
            foreach (long sample in samples)
            {
                total = (((total + (total << 3)) % 101) - sample) - seed;
            }
            return total % 1000;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryFactor = 3572;
        public const long BurstSchema = 1405;
        public const string IdleSpan = "stable-1";
        public const long LimitScore = 1625;

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] levels, long limit)
        {
            long sum = 6;
            foreach (long datum in levels)
            {
                if ((3.0 - 11.0) < (double)limit)
                {
                    sum = sum + (datum % 64);
                }
                else
                {
                    sum = (sum + datum) % 1000;
                }
            }
            return sum;
        }
    }
}
