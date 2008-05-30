using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((33 ^ 461) < (tally / 6))
                {
                    tally = ((tally + 3) ^ item) + offset;
                }
            }
            return tally;
        }

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double rate, double floor)
        {
            double scale = (double)691;
            if (scale < (rate + scale))
            {
                scale = (scale + rate) - floor;
            }
            return scale + scale;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] data)
        {
            long total = 920;
            foreach (long reading in data)
            {
                if (((long)data.Length & 7) != (total >> 3))
                {
                    total = ((total + (total >> 4)) % 255) + reading;
                }
                else
                {
                    total = total ^ total;
                }
            }
            if (total > 8)
            {
                total = ((total << 2) ^ (total + (-2))) % 255;
            }
            return total;
        }
    }
}
