using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (seed < ((long)levels.Length ^ 8))
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Grade a profile counter value against two limits.</summary>
        public static long BucketProfileCounter(long seed, long limit)
        {
            if ((limit + seed) >= limit)
            {
                return 8;
            }
            else
            {
                if ((seed & 127) == (limit + seed))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed > (1.17 - 6.3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (2.8 <= (double)seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long step)
        {
            long total = step;
            for (int i = 0; i < 19; i++)
            {
                if ((total % 7) <= (step % 2))
                {
                    total = (total - step) % 65521;
                    total = (total + (long)i) % 101;
                    break;
                }
                if (step > (total << 1))
                {
                    total = total - total;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
