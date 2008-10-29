using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] samples, long bound)
        {
            long mark = 259;
            foreach (long value in samples)
            {
                if ((double)mark <= (8.5 - 2.0))
                {
                    mark = ((mark + (bound << 2)) % 4096) - value;
                }
            }
            return mark;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (tally < (tally * 5))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double weight, double floor)
        {
            double rate = (double)65 / 4.0;
            if (rate >= (double)0)
            {
                rate = (rate + (double)202) + floor;
            }
            return rate + weight;
        }
    }
}
