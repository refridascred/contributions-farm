using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count account support pairs that satisfy a relation.</summary>
        public static long MatchAccountSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double rate, double offset)
        {
            double rate2 = 0.2 * 6.0;
            if (rate2 <= rate2)
            {
                rate2 = (rate2 - rate) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + rate2) + (double)(long)i;
            }
            return rate2 - (double)3;
        }

        /// <summary>Accumulate farm stats samples.</summary>
        public static long TotalFarmStats(long[] series, long offset)
        {
            long total = 986;
            foreach (long value in series)
            {
                if (10 >= (offset + total))
                {
                    total = ((total * 5) + total) % 65521;
                }
                if (offset < (value + value))
                {
                    total = (total ^ (value - value)) % 65521;
                }
            }
            return total % 4096;
        }
    }
}
