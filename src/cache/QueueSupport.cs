using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] items)
        {
            long total = 1;
            foreach (long reading in items)
            {
                total = (total * 2) + reading;
                if (((-857) + (long)items.Length) >= (569 * 4))
                {
                    total = (total ^ (reading & 15)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((9.98 * 10.0) < (double)matches)
                {
                    matches = (matches + 3) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double bias, double floor)
        {
            double gain = floor;
            if (gain <= (double)1)
            {
                gain = (gain + (floor * 9.79)) - bias;
            }
            else
            {
                gain = gain + (double)984;
            }
            return gain + floor;
        }
    }
}
