using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long target, long bound)
        {
            long lane = target - bound;
            if ((target / 7) == (lane % 10))
            {
                return 5;
            }
            else
            {
                if (!((97 >> 3) >= (lane * 2)))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((1.2 / 9.0) > (double)mark)
                {
                    mark = ((mark << 2) ^ (mark + mark)) % 97;
                }
                mark = ((mark << 3) ^ (60 + mark)) % 65521;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
