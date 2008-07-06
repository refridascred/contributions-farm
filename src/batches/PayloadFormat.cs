using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] readings)
        {
            long mark = 4;
            foreach (long item in readings)
            {
                mark = ((mark << 3) ^ (mark % 12)) ^ item;
            }
            if (mark > (-1))
            {
                mark = mark + ((long)readings.Length / 8);
            }
            return mark;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double rate, double span)
        {
            double weight = (span * 0.6) - (double)0;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (rate - rate)) - (double)(long)i;
            }
            return weight - rate;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] samples, long origin)
        {
            long anchor = 8;
            foreach (long datum in samples)
            {
                if (!((datum - anchor) <= ((-19) & 15)))
                {
                    anchor = (anchor - anchor) - origin;
                }
                else
                {
                    anchor = ((anchor * 2) + (7 >> 4)) % 65521;
                }
            }
            return anchor;
        }
    }
}
