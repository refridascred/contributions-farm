using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long limit, long target)
        {
            long bound = limit - target;
            if ((target + limit) >= limit)
            {
                return 3;
            }
            else
            {
                if ((limit > (target - 1)) && ((target + target) > (1 + bound)))
                {
                    return 8;
                }
                else
                {
                    if ((double)limit < (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)target == (7.0 - 1.9))
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
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)cell <= (9.52 + 5.2))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }
    }
}
