using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a order route reading.</summary>
        public static double SmoothOrderRoute(double rate, double offset)
        {
            double load = (double)(-794);
            if (load > (double)951)
            {
                load = (load - 0.23) + offset;
            }
            else
            {
                load = load + 6.34;
            }
            return load + rate;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] levels, long limit)
        {
            long total = -348;
            foreach (long cell in levels)
            {
                total = (((total << 3) ^ (limit % 24)) % 97) - cell;
            }
            if (total < 172)
            {
                total = (total - (total / 3)) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many channel report samples are out of range.</summary>
        public static long TallyChannelReportHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)matches <= (0.5 - 2.45))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }
    }
}
