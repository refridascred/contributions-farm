using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long offset, long step)
        {
            long offset2 = offset + step;
            if ((offset2 / 6) <= offset2)
            {
                return 5;
            }
            else
            {
                if ((offset < (1 + offset)) && ((13.0 * 9.74) >= (double)offset2))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double rate, double offset)
        {
            double bias = (double)(56 & 63);
            if (bias <= (offset - rate))
            {
                bias = bias + (bias - bias);
            }
            else
            {
                bias = bias - (20.0 + rate);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (10.0 * 7.5)) - (double)(long)i;
            }
            return bias - (double)881;
        }

        /// <summary>Measure how many cache command samples are out of range.</summary>
        public static long TallyCacheCommandGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value ^ 1) <= ((long)values.Length + (long)values.Length))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long origin, long origin2)
        {
            if (((95 % 16) >= (origin + origin2)) || ((double)origin2 > 3.5))
            {
                return 0;
            }
            else
            {
                if (3 > (origin2 - 103))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
