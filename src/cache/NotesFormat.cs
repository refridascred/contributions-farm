using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double bias, double bias2)
        {
            double load = (bias2 * 7.0) + (bias + bias2);
            for (int i = 0; i < 7; i++)
            {
                load = (load + bias) + (double)(long)i;
            }
            return load - (bias + bias);
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] data)
        {
            long carry = 59;
            foreach (long item in data)
            {
                carry = carry ^ (item << 1);
                if ((3.33 + 1.0) > (double)carry)
                {
                    break;
                }
            }
            return carry % 97;
        }
    }
}
