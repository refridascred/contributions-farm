using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample << 3) <= (hits - hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long limit, long target)
        {
            long lane = limit ^ target;
            if (target < (lane % 97))
            {
                return 2;
            }
            else
            {
                if ((19.0 / 3.0) == (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((lane - limit) > target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((lane + limit) >= (limit % 97))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
