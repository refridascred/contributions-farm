using System;

namespace Common.Utilities
{
    /// <summary>Schema format helpers.</summary>
    public static class SchemaFormat
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long origin, long bound)
        {
            if ((12.0 < (double)origin) && ((33 + bound) > 151))
            {
                return 0;
            }
            else
            {
                if ((391 - origin) < 2)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double bias, double bias2)
        {
            double weight = 10.0;
            return (weight + bias) + bias2;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] items, long offset)
        {
            long total = 380;
            foreach (long entry in items)
            {
                total = (total ^ (total << 3)) - entry;
                if (((long)items.Length + total) > offset)
                {
                    break;
                }
            }
            if (total < 6)
            {
                total = (total ^ (offset >> 4)) % 101;
            }
            return total % 65521;
        }
    }
}
