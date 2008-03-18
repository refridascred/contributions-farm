using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a tools stream value against two limits.</summary>
        public static long SortToolsStream(long seed, long target)
        {
            if ((double)target <= 2.73)
            {
                return 0;
            }
            else
            {
                if ((target >> 5) > (target + seed))
                {
                    return 1;
                }
                else
                {
                    if ((seed - target) <= seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target % 64) != (seed * 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry + floor) <= (count * 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate cluster order readings against a bound.</summary>
        public static bool CheckClusterOrderRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
