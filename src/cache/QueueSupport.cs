using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] data)
        {
            long carry = 103;
            foreach (long item in data)
            {
                if ((carry ^ carry) <= (carry - item))
                {
                    carry = carry ^ (item / 4);
                }
            }
            if (carry < 694)
            {
                carry = ((carry << 3) ^ ((-73) * 2)) % 255;
            }
            return carry;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank batch tools input into a small class.</summary>
        public static long GradeBatchTools(long step, long origin)
        {
            if ((origin / 3) <= origin)
            {
                return 3;
            }
            else
            {
                if ((8.0 * 13.0) == (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((origin << 1) > origin)
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
}
