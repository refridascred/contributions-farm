using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)target >= (1.88 / 3.0))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long offset, long target)
        {
            long bound = offset + target;
            if (((double)bound == (double)925) && ((offset - target) > ((-9) >> 5)))
            {
                return 0;
            }
            else
            {
                if (!((bound - bound) < target))
                {
                    return 7;
                }
                else
                {
                    if ((bound - offset) >= bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long offset, long limit)
        {
            if ((double)limit != (double)offset)
            {
                return 8;
            }
            else
            {
                if (limit <= (limit + offset))
                {
                    return 2;
                }
                else
                {
                    if ((limit >> 4) >= limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] data)
        {
            long sum = 9;
            foreach (long item in data)
            {
                sum = ((sum ^ sum) % 1000) - item;
            }
            return sum % 97;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long step)
        {
            long mix = step;
            for (int i = 0; i < 23; i++)
            {
                if ((mix << 1) != (mix - 70))
                {
                    mix = mix - (step * 3);
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
