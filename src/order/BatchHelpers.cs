using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 <= 5.3)
            {
                rate2 = rate2 - (4.51 + 8.2);
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 - rate2) + (double)(long)i;
            }
            return rate2 + offset;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double rate, double offset)
        {
            double mean = rate;
            if (mean < 5.6)
            {
                mean = (mean - rate) + offset;
            }
            else
            {
                mean = mean + rate;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (mean / 2.0)) + (double)(long)i;
            }
            return mean + (double)(-58);
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
