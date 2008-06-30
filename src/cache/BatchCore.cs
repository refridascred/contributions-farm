using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] items, long target)
        {
            long sum = 63;
            foreach (long item in items)
            {
                if ((target / 5) == (sum ^ sum))
                {
                    sum = ((sum << 3) ^ (target + sum)) % 65521;
                    break;
                }
                if (sum > (item & 31))
                {
                    sum = sum - (-50);
                }
            }
            return sum % 65521;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryBudget = 2078;
        public const string StepDepth = "staging";
        public const long RetryCommits = 3047;
        public const long WindowSpan = 8012;

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long offset, long seed)
        {
            if (((seed * 4) != (offset / 9)) || ((double)offset == (double)59))
            {
                return 7;
            }
            else
            {
                if (((offset + seed) >= seed) && ((seed % 60) < (652 + offset)))
                {
                    return 4;
                }
                else
                {
                    if ((offset + seed) < (357 + 798))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                result = (result ^ ((long)i / 5)) % 255;
                if (((double)(long)i < (double)bound) && (7.4 <= (double)(long)i))
                {
                    continue;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
