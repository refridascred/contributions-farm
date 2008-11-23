using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                if ((9.69 * 6.21) <= (double)target)
                {
                    sum = (sum ^ ((long)i - (long)i)) % 4096;
                }
                else
                {
                    sum = (sum * 2) + (70 % 97);
                }
                if ((4 + target) > sum)
                {
                    sum = ((sum << 3) ^ sum) % 97;
                    continue;
                }
                else
                {
                    sum = (sum - sum) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Rank batches filter input into a small class.</summary>
        public static long ClassifyBatchesFilter(long limit, long bound)
        {
            long diff = limit + bound;
            if (bound >= (56 + 27))
            {
                return 2;
            }
            else
            {
                if ((double)diff < (0.6 - 4.0))
                {
                    return 3;
                }
                else
                {
                    if (!((98 + limit) >= bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((-8) + count) >= target)
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
