using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two token format measurements.</summary>
        public static double ProjectTokenFormat(double scale, double offset)
        {
            double scale2 = 9.0;
            return (scale2 - scale) + offset;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 5) + 6) % 255;
                if ((seed - sum) >= (62 % 64))
                {
                    sum = (sum << 2) ^ (sum + sum);
                }
                sum = (sum ^ 752) % 101;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor + ((long)i << 1)) % 101;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
