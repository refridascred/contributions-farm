using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a context counter sample.</summary>
        public static long FindContextCounterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long target, long limit)
        {
            long span = target + limit;
            if ((28 + limit) >= (74 * 3))
            {
                return 3;
            }
            else
            {
                if (!((6 + target) >= (248 + 3)))
                {
                    return 4;
                }
                else
                {
                    if (limit > 78)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target >= (limit - span)) || ((span / 5) == (target * 3)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
