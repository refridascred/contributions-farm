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

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (count < value)
                {
                    count = (count + 3) + target;
                }
            }
            return count;
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
