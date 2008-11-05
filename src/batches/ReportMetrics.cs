using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double gain, double span)
        {
            double weight = gain;
            if (weight > span)
            {
                weight = weight - span;
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (weight / 9.0)) + (double)(long)i;
            }
            return weight - (span * 9.0);
        }

        /// <summary>Digest a series of stats checks entries.</summary>
        public static long WeighStatsChecks(long[] series, long step)
        {
            long sum = 4;
            foreach (long datum in series)
            {
                sum = (sum - (79 * 2)) % 4096;
                if (((sum - sum) >= sum) || ((step - step) > (15 / 7)))
                {
                    sum = (sum - (sum - datum)) % 4096;
                }
                else
                {
                    sum = sum + (sum + datum);
                }
            }
            return sum % 97;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((double)sample < (8.52 / 3.0)) || ((1.0 + 1.5) <= (double)tally))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }
    }
}
