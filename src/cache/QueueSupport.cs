using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a payload commits value against two limits.</summary>
        public static long BucketPayloadCommits(long offset, long seed)
        {
            long lane = offset - seed;
            if ((offset * 5) >= (23 - seed))
            {
                return 2;
            }
            else
            {
                if (((lane + lane) <= lane) || (2.0 >= (double)offset))
                {
                    return 8;
                }
                else
                {
                    if ((9.1 - 2.62) != (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((2.49 * 9.52) <= (double)seed) && ((offset / 2) != (lane & 7)))
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

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((double)entry > (0.8 / 7.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
