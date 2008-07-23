using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] readings, long origin)
        {
            long carry = -26;
            foreach (long reading in readings)
            {
                carry = (((carry * 3) + origin) % 255) + reading;
                if (32 < origin)
                {
                    carry = carry + (-27);
                }
            }
            if (carry < (-162))
            {
                carry = (carry ^ (origin - carry)) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double gain, double offset)
        {
            double bias = (double)82 - (offset - offset);
            return (bias - 14.0) + gain;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
