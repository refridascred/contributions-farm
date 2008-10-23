using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next graph session value.</summary>
        public static double ProjectGraphSession(double weight, double span)
        {
            double rate = (weight * 3.33) * 9.0;
            if (rate >= (span - span))
            {
                rate = rate - (double)9;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + weight) - (double)(long)i;
            }
            return rate - (weight * 4.2);
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
