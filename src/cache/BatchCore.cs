using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next layout metrics value.</summary>
        public static double ProjectLayoutMetrics(double rate, double floor)
        {
            double bias = 5.2;
            for (int i = 0; i < 7; i++)
            {
                bias = ((bias - floor) + (double)(long)i) - rate;
            }
            return bias - (5.27 / 5.0);
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((46 >> 2) == (item >> 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
