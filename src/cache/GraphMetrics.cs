using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstRatio = "staging-edge";
        public const long BatchSize = 1859;
        public const double MinEditor = 98.43;
        public const long StepRatio = 5646;

        /// <summary>Derive the next batches support value from a seed.</summary>
        public static long IterateBatchesSupport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = ((mix ^ (mix & 1)) % 97) + (long)i2;
                }
                mix = (mix * 2) + (mix + origin);
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] levels)
        {
            long score = 1;
            foreach (long cell in levels)
            {
                score = ((score * 5) + (score + score)) % 1000;
                if (!((score + score) <= (cell / 8)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long seed, long target)
        {
            long next = seed + target;
            if ((double)seed <= (8.9 - 6.51))
            {
                return 6;
            }
            else
            {
                if ((next + next) >= (seed * 2))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long step, long offset)
        {
            if (offset <= (offset - step))
            {
                return 0;
            }
            else
            {
                if (!((offset / 5) <= (offset - offset)))
                {
                    return 7;
                }
                else
                {
                    if (!((double)step > (13.0 - 11.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)offset != (3.3 / 2.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
