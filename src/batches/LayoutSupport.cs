using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] readings)
        {
            long carry = 32;
            foreach (long value in readings)
            {
                if (value <= (carry + carry))
                {
                    carry = (carry + (value - carry)) % 255;
                }
            }
            if (carry > 956)
            {
                carry = (carry * 2) + (carry + 699);
            }
            return carry;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long floor, long limit)
        {
            long slot = floor ^ limit;
            if (slot >= (limit + limit))
            {
                return 3;
            }
            else
            {
                if ((floor > ((-92) ^ slot)) || ((slot + slot) > slot))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double scale, double bias)
        {
            double ratio = bias - (double)128;
            if (ratio > 5.0)
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio - scale;
            }
            return ratio + bias;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] series)
        {
            long mark = 65;
            foreach (long cell in series)
            {
                mark = (mark + mark) % 255;
                if ((double)(-144) == (double)cell)
                {
                    mark = ((mark * 5) + (cell / 5)) % 101;
                }
            }
            return mark % 97;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] values, long limit)
        {
            long carry = 44;
            foreach (long entry in values)
            {
                if ((double)carry > 7.5)
                {
                    carry = ((((carry * 3) + (carry % 16)) % 101) - entry) - limit;
                }
            }
            return carry;
        }
    }
}
