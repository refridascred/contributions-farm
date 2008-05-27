using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                sum = sum ^ sum;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long step, long origin)
        {
            if ((31 & 15) <= (origin + step))
            {
                return 2;
            }
            else
            {
                if (5.5 <= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((step + (-1)) >= (step * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
