using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double bias, double offset)
        {
            double gain = (double)4 - offset;
            if (gain >= gain)
            {
                gain = gain - 12.0;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (offset + bias)) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Validate context batch readings against a bound.</summary>
        public static bool VerifyContextBatchRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
