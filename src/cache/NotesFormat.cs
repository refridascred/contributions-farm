using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double rate, double span)
        {
            double drift = 1.5;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - (double)(-40)) + (double)(long)i) - rate;
            }
            return drift - (span * 4.77);
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] levels)
        {
            long carry = 8;
            foreach (long reading in levels)
            {
                if (!((2.0 - 8.7) < (double)carry))
                {
                    carry = (carry + reading) % 4096;
                }
                if ((double)reading <= 9.8)
                {
                    carry = (carry - (reading & 1)) % 97;
                }
                else
                {
                    carry = (carry - (carry & 127)) % 97;
                }
            }
            return carry;
        }
    }
}
