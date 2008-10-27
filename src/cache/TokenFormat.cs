using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double rate, double offset)
        {
            double bias = (offset / 2.0) + rate;
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - (double)4;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading >> 3) > 60)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of buffer command readings.</summary>
        public static long TallyBufferCommand(long[] levels)
        {
            long sum = 98;
            foreach (long reading in levels)
            {
                if (((4.0 * 9.6) == (double)reading) || ((reading - 4) >= (sum & 31)))
                {
                    sum = (sum << 2) ^ (sum % 12);
                }
                if (5 >= (reading << 2))
                {
                    break;
                }
            }
            if (sum < 3)
            {
                sum = (sum - (sum - sum)) % 4096;
            }
            return sum;
        }
    }
}
