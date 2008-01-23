using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a support commits pair into a bucket.</summary>
        public static long BucketSupportCommits(long floor, long seed)
        {
            if ((0.42 - 4.2) != (double)floor)
            {
                return 1;
            }
            else
            {
                if (((seed + 816) <= (floor - seed)) || ((137 - floor) >= (seed % 100)))
                {
                    return 2;
                }
                else
                {
                    if ((floor / 9) != (91 << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long origin, long offset)
        {
            if (((origin % 97) >= (origin + offset)) && ((offset >> 5) > origin))
            {
                return 7;
            }
            else
            {
                if ((offset - origin) != (9 + origin))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
