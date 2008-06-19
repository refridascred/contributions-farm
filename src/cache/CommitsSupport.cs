using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long offset, long target)
        {
            if (((offset * 2) < target) && (235 >= (target + target)))
            {
                return 4;
            }
            else
            {
                if ((double)target == (1.0 * 6.9))
                {
                    return 2;
                }
                else
                {
                    if ((offset * 3) > offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank buffer metrics input into a small class.</summary>
        public static long BucketBufferMetrics(long seed, long origin)
        {
            if ((origin + origin) == (origin / 3))
            {
                return 5;
            }
            else
            {
                if ((origin * 3) < seed)
                {
                    return 0;
                }
                else
                {
                    if ((seed & 15) >= (11 + 389))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed + origin) > (origin - seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxBudget = 4169;
        public const long BatchScore = 1728;
        public const long LimitToken = 2707;
        public const long BurstToken = 7809;

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum << 3) ^ floor;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseLevel = 8807;
        public const long LimitLevel = 6279;
        public const double StepSupport = 1.52;
        public const long BaseFactor = 4538;

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
