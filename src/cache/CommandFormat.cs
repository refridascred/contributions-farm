using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double ratio, double span)
        {
            double bias = 16.0 + span;
            if (bias <= (span * 4.64))
            {
                bias = bias - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (ratio / 9.0)) + (double)(long)i;
            }
            return bias - (double)3;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long limit, long target)
        {
            long delta = limit - target;
            if ((delta + delta) >= delta)
            {
                return 0;
            }
            else
            {
                if (90 >= delta)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((double)floor > 3.8) && ((908 >> 2) < (total % 2)))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Locate a context buffer reading by value.</summary>
        public static long FindContextBufferIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
