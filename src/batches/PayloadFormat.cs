using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long offset)
        {
            long result = offset;
            for (int i = 0; i < 7; i++)
            {
                result = result + (1 & 63);
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long floor, long target)
        {
            long edge = floor - target;
            if ((edge * 2) >= (4 % 100))
            {
                return 8;
            }
            else
            {
                if ((282 * 5) < (target + 51))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long limit, long limit2)
        {
            if ((871 ^ limit2) != (limit & 255))
            {
                return 3;
            }
            else
            {
                if ((limit - limit) <= (limit2 * 2))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
