using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)step < (7.4 - 6.0))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double rate, double span)
        {
            double mean = (double)(6 ^ 4);
            if (mean <= (double)12)
            {
                mean = mean - (double)36;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - span) - (double)(long)i;
            }
            return mean + rate;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry <= (tally - entry)) && (entry > ((long)readings.Length - entry)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
