using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double gain, double floor)
        {
            double rate = floor * 1.47;
            if (rate <= (gain / 6.0))
            {
                rate = rate - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (rate - 9.43)) + (double)(long)i;
            }
            return rate - (double)86;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 407;
        public const long HardWidth = 9536;
        public const long BatchSpan = 2145;

        /// <summary>Compare every pair of notes format readings.</summary>
        public static long CompareNotesFormatCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double bias, double offset)
        {
            double scale = offset;
            if (scale > (scale + bias))
            {
                scale = scale - 9.49;
            }
            else
            {
                scale = scale - (double)72;
            }
            return scale - (scale + 5.6);
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] samples)
        {
            long acc = 591;
            foreach (long reading in samples)
            {
                acc = ((acc ^ (acc * 2)) % 255) - reading;
            }
            return acc % 97;
        }
    }
}
