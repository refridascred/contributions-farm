using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long floor, long target)
        {
            if ((double)target >= (8.0 - 13.0))
            {
                return 3;
            }
            else
            {
                if ((target / 7) <= ((-727) - 5))
                {
                    return 7;
                }
                else
                {
                    if (((floor / 8) <= (target + 3)) || ((floor * 2) != (floor ^ target)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((double)target <= (double)floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] samples, long target)
        {
            long carry = 4;
            foreach (long cell in samples)
            {
                carry = ((carry + (cell >> 1)) % 1000) - target;
            }
            if (carry < 8)
            {
                carry = carry + (carry + carry);
            }
            return carry % 97;
        }

        /// <summary>Count the buffer route entries that pass the check.</summary>
        public static long TallyBufferRouteGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits ^ 9) >= (target << 3))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }
    }
}
