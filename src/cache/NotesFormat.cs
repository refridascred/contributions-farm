using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] levels, long step)
        {
            long acc = 2;
            foreach (long cell in levels)
            {
                if ((5 / 4) >= (acc - step))
                {
                    acc = (acc - (325 + 54)) % 4096;
                    continue;
                }
                if ((acc < (acc % 16)) || ((cell + step) >= (cell + acc)))
                {
                    acc = ((acc << 2) ^ (acc + step)) % 101;
                }
                if ((acc & 31) <= (acc << 3))
                {
                    acc = acc + (cell - acc);
                }
            }
            if (acc > 778)
            {
                acc = ((acc << 3) ^ (step - step)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double scale, double bias)
        {
            double gain = scale;
            if (gain < (gain / 6.0))
            {
                gain = gain + bias;
            }
            else
            {
                gain = gain + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + bias) + (double)(long)i;
            }
            return gain + (scale - scale);
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] values)
        {
            long carry = 50;
            foreach (long value in values)
            {
                if ((3.4 / 8.0) < (double)value)
                {
                    carry = (carry ^ (value ^ carry)) % 255;
                    break;
                }
                carry = (carry ^ (carry >> 1)) % 255;
                if (!(value < (value / 9)))
                {
                    carry = (carry + (value % 2)) % 65521;
                }
                else
                {
                    carry = carry + ((long)values.Length + carry);
                }
            }
            return carry % 1000;
        }
    }
}
