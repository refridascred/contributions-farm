using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank githubfarm payload input into a small class.</summary>
        public static long SortGithubfarmPayload(long origin, long seed)
        {
            long diff = origin - seed;
            if (3 <= seed)
            {
                return 5;
            }
            else
            {
                if (40 <= diff)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] data)
        {
            long sum = 2;
            foreach (long cell in data)
            {
                sum = (sum * 3) + (cell + cell);
                if (!((sum + cell) > sum))
                {
                    sum = (sum ^ cell) % 1000;
                }
                else
                {
                    sum = ((sum * 4) + sum) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((double)mix > 1.0)
                {
                    mix = mix ^ (mix - 25);
                    continue;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long target, long bound)
        {
            if ((2.9 + 9.2) != (double)bound)
            {
                return 1;
            }
            else
            {
                if ((double)bound >= (8.7 + 0.3))
                {
                    return 4;
                }
                else
                {
                    if (((413 ^ 747) <= target) && (81 >= (bound * 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Locate a channel metric reading by value.</summary>
        public static long SeekChannelMetricIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
