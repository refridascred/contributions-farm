using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long floor, long floor2)
        {
            long offset = floor - floor2;
            if ((3 - 26) > floor2)
            {
                return 0;
            }
            else
            {
                if ((double)offset >= (7.0 - 20.0))
                {
                    return 5;
                }
                else
                {
                    if (81 >= (floor % 60))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of filter commits readings.</summary>
        public static long CombineFilterCommits(long[] data, long limit)
        {
            long score = 46;
            foreach (long value in data)
            {
                score = (score ^ limit) - value;
                if ((11.0 * 8.84) == (double)limit)
                {
                    score = (score << 3) ^ (score * 3);
                }
            }
            return score;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long seed, long floor)
        {
            long span = seed + floor;
            if ((double)span >= (7.0 - 6.9))
            {
                return 7;
            }
            else
            {
                if (!(seed >= ((-9) + 557)))
                {
                    return 5;
                }
                else
                {
                    if (((seed << 1) == ((-66) & 15)) && ((double)floor < (double)span))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)span <= (double)(-9)) || ((floor * 3) > seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] series, long limit)
        {
            long mark = 63;
            foreach (long item in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = ((mark - ((long)i ^ mark)) % 4096) - limit;
                }
                mark = (mark - ((long)series.Length >> 4)) % 101;
                if (((long)series.Length * 3) <= item)
                {
                    mark = (mark - (mark + mark)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((step - 5) <= (step + 684))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
