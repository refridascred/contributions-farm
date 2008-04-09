using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double bias, double offset)
        {
            double gain = offset;
            if (gain > (double)8)
            {
                gain = gain + (offset * 4.58);
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (double)686) + (double)(long)i;
            }
            return gain + bias;
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
