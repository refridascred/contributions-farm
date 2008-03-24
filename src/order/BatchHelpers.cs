using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate cluster counter readings against a bound.</summary>
        public static bool GuardClusterCounterRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long target, long target2)
        {
            long edge = target - target2;
            if (61 > (target + edge))
            {
                return 8;
            }
            else
            {
                if ((target2 + target) > (target2 - edge))
                {
                    return 4;
                }
                else
                {
                    if ((target >> 5) < edge)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((2.97 - 20.0) < (double)edge)
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
        }
    }
}
