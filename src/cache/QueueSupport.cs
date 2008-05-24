using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                total = (total - (total & 255)) % 4096;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long floor, long target)
        {
            long next = floor + target;
            if ((32 * 4) != (target % 12))
            {
                return 0;
            }
            else
            {
                if ((677 > (target - target)) || ((target << 2) < (floor & 63)))
                {
                    return 7;
                }
                else
                {
                    if (next < (target - target))
                    {
                        return 8;
                    }
                    else
                    {
                        if (991 <= (530 - target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
