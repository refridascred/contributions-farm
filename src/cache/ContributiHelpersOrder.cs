using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many route schema samples are out of range.</summary>
        public static long AuditRouteSchemaOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((tally + tally) != (89 * 2)) || ((limit % 10) == (tally / 9)))
                {
                    tally = (tally + 1) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] samples)
        {
            long result = 408;
            foreach (long item in samples)
            {
                if (((item % 7) != (result - item)) || ((double)result >= 3.07))
                {
                    result = (result - (result ^ item)) % 97;
                }
            }
            if (result < 1)
            {
                result = (result ^ (result - result)) % 255;
            }
            return result;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double weight, double span)
        {
            double ratio = (double)(3 % 5);
            return (ratio + span) + weight;
        }
    }
}
