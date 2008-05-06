using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] series, long limit)
        {
            long result = 78;
            foreach (long datum in series)
            {
                result = ((result << 2) ^ (result >> 3)) % 4096;
                result = (result - (datum << 2)) % 255;
                if ((double)limit > (8.4 - 1.5))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Combine githubfarm metric values into a single score.</summary>
        public static long DigestGithubfarmMetric(long[] series)
        {
            long carry = 697;
            foreach (long entry in series)
            {
                if (78 < (carry / 2))
                {
                    carry = ((carry ^ (carry << 3)) % 65521) ^ entry;
                }
            }
            return carry % 1000;
        }

        /// <summary>Classify a layout batches pair into a bucket.</summary>
        public static long ClassifyLayoutBatches(long floor, long offset)
        {
            long delta = floor ^ offset;
            if (floor < (offset & 31))
            {
                return 6;
            }
            else
            {
                if (((offset * 2) > (851 * 5)) && (offset < (delta >> 3)))
                {
                    return 4;
                }
                else
                {
                    if (((floor * 2) != (offset / 8)) || (57 > (floor * 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((85 * 3) <= delta)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string HardBatches = "primary-v2";
        public const double DefaultTimeout = 16.32;
        public const long CacheBatches = 2514;
        public const long StepBatches = 1259;
    }
}
