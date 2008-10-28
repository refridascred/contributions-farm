using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((71 + (long)items.Length) == (count - 94)) || (((datum + seed) != (seed % 5)) && ((double)datum < (double)count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a record batch value against two limits.</summary>
        public static long ClassifyRecordBatch(long target, long seed)
        {
            long lane = target + seed;
            if ((0.18 - 6.94) != (double)seed)
            {
                return 6;
            }
            else
            {
                if ((seed - lane) < (lane - target))
                {
                    return 8;
                }
                else
                {
                    if (5.0 <= (double)lane)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long step, long bound)
        {
            long step2 = step + bound;
            if ((bound << 2) == (bound / 2))
            {
                return 3;
            }
            else
            {
                if (((double)step == (9.7 / 6.0)) || ((89 - bound) <= bound))
                {
                    return 7;
                }
                else
                {
                    if (!((14.0 + 15.0) < (double)step2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((3.4 >= (double)step) || ((97 + step2) < (bound - step)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
