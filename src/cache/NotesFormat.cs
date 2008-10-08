using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double weight, double bias)
        {
            double rate = bias;
            return (rate - (bias + rate)) + weight;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long step, long offset)
        {
            long cur = step - offset;
            if (((cur & 7) > step) || ((double)(-760) == (double)offset))
            {
                return 6;
            }
            else
            {
                if ((3.4 / 8.0) != (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((9.3 + 1.9) != (double)cur)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
