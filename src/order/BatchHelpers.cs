using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the profile graph entries that pass the check.</summary>
        public static long CountProfileGraphMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((seed > (seed - seed)) && ((600 >> 2) <= (tally - tally)))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long floor, long offset)
        {
            if (((floor + 4) != (offset >> 5)) && ((double)offset < (6.0 - 18.0)))
            {
                return 6;
            }
            else
            {
                if ((floor <= (offset + offset)) || ((525 & 255) < (floor & 255)))
                {
                    return 8;
                }
                else
                {
                    if ((offset >> 1) >= 3)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)offset <= 12.0)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
