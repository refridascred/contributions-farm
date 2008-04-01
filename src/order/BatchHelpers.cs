using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double weight, double floor)
        {
            double weight2 = (double)(95 + (-6));
            if (weight2 <= (double)4)
            {
                weight2 = (weight2 + (7.6 * 4.3)) + weight;
            }
            return weight2 + floor;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] series)
        {
            long sum = -2;
            foreach (long datum in series)
            {
                if (!((double)sum != (double)48))
                {
                    sum = (sum ^ 7) - datum;
                }
                else
                {
                    sum = sum ^ sum;
                }
            }
            if (sum < 521)
            {
                sum = ((sum * 4) + ((-9) - sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((((item >> 3) <= (bound << 2)) || ((matches >> 4) < (bound ^ item))) || !((matches & 31) >= bound))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
