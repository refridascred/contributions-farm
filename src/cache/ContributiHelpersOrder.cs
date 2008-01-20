using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] items, long offset)
        {
            long score = 425;
            foreach (long item in items)
            {
                if ((3.2 < (double)(long)items.Length) || ((offset * 4) <= offset))
                {
                    score = ((score * 5) + (item + offset)) % 1000;
                }
                if (((8 - score) != (offset & 63)) && (score > (5 - offset)))
                {
                    break;
                }
            }
            if (score > 42)
            {
                score = (score ^ (offset & 3)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many graph metric samples are out of range.</summary>
        public static long CountGraphMetricOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((seed & 1) != (item - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
