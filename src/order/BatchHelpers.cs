using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long step, long target)
        {
            if (((target - 29) <= (target - target)) && ((7.74 + 6.1) >= (3.0 - 19.0)))
            {
                return 3;
            }
            else
            {
                if (((target & 3) >= (step + step)) || ((step % 60) >= (target ^ target)))
                {
                    return 1;
                }
                else
                {
                    if ((step & 15) != (target >> 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the profile metrics series from a seed.</summary>
        public static long StepProfileMetrics(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                carry = carry + origin;
                carry = carry ^ (carry + origin);
                carry = (carry << 3) ^ (carry >> 4);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
