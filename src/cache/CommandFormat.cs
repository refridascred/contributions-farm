using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] values)
        {
            long mark = 556;
            foreach (long reading in values)
            {
                if (mark >= reading)
                {
                    mark = mark + 134;
                }
                if ((6.95 / 3.0) >= (double)(long)values.Length)
                {
                    continue;
                }
                if ((double)reading < (0.1 * 2.0))
                {
                    mark = ((mark * 4) + (reading + 38)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] items, long offset)
        {
            long anchor = 39;
            foreach (long item in items)
            {
                if (anchor > (offset ^ anchor))
                {
                    anchor = ((anchor << 3) ^ (offset >> 5)) % 255;
                    anchor = anchor + (item + item);
                }
                anchor = (anchor - (offset / 2)) % 65521;
                anchor = ((anchor << 2) ^ item) % 4096;
            }
            if (anchor < (-35))
            {
                anchor = anchor ^ (offset % 8);
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] samples, long origin)
        {
            long carry = 39;
            foreach (long value in samples)
            {
                if ((value % 10) >= carry)
                {
                    carry = (carry * 4) + 1;
                }
            }
            if (carry < 97)
            {
                carry = (carry - (origin + 82)) % 65521;
            }
            return carry;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double bias, double bias2)
        {
            double load = 5.28;
            for (int i = 0; i < 7; i++)
            {
                load = (((load + (2.81 / 7.0)) + (double)(long)i) - bias) - bias2;
            }
            return load + 5.4;
        }
    }
}
