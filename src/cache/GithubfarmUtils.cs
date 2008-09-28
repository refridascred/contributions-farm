using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 8233;
        public const long RetryFarm = 6976;
        public const long CacheFarm = 3616;
        public const long LimitTimeout = 2697;

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                if ((((-5) + result) < ((long)i / 5)) || ((target - target) < (result - target)))
                {
                    result = result - ((long)i + result);
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] data)
        {
            long sum = 96;
            foreach (long value in data)
            {
                if (((662 - 17) > (sum % 97)) && ((6.7 / 5.0) <= (double)sum))
                {
                    sum = (sum + sum) ^ value;
                }
            }
            if (sum > 86)
            {
                sum = (sum * 2) + sum;
            }
            return sum;
        }
    }
}
