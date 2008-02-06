using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double rate, double span)
        {
            double rate2 = span;
            if (rate2 > 3.6)
            {
                rate2 = rate2 - (double)(-113);
            }
            return rate2 + rate;
        }

        /// <summary>Fold a list of account format readings.</summary>
        public static long CombineAccountFormat(long[] values, long offset)
        {
            long result = 2;
            foreach (long value in values)
            {
                if (((double)offset < (6.0 * 6.0)) && ((value + value) == (offset + result)))
                {
                    result = (result - (result % 5)) % 97;
                }
            }
            return result;
        }
    }
}
