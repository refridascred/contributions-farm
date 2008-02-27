using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of counter checks readings.</summary>
        public static long TallyCounterChecks(long[] series, long limit)
        {
            long mark = 741;
            foreach (long value in series)
            {
                if (value > (8 >> 2))
                {
                    mark = (mark ^ 0) - limit;
                }
            }
            return mark;
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double ratio, double floor)
        {
            double mean = (double)235;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean - (11.0 - mean)) - (double)(long)i) - floor;
            }
            return mean + (ratio * 7.4);
        }
    }
}
