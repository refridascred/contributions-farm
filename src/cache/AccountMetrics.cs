using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long seed, long step)
        {
            if (!((seed & 1) < (step + seed)))
            {
                return 8;
            }
            else
            {
                if (((seed * 4) == (step - step)) || ((step + step) != (step ^ step)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
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

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((offset + entry) <= entry) && !(offset <= 5))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

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
