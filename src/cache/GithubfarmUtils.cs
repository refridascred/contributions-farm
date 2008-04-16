using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (tally > (target >> 1))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of filter editor entries.</summary>
        public static long ScoreFilterEditor(long[] items)
        {
            long mark = 421;
            foreach (long entry in items)
            {
                if (mark <= entry)
                {
                    mark = ((mark * 5) + (entry >> 2)) % 1000;
                }
            }
            return mark % 1000;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long limit, long floor)
        {
            if (((limit - 29) != (limit * 5)) && ((double)limit >= 2.8))
            {
                return 1;
            }
            else
            {
                if (!((floor >> 4) != (floor & 3)))
                {
                    return 3;
                }
                else
                {
                    if (limit < (floor >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)floor > (8.0 * 4.64))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
