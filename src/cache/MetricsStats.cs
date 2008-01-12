using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum <= (datum % 8)) || (((15.0 - 3.34) >= (double)datum) || ((62 ^ datum) <= (341 * 4))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public bool Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double scale, double floor)
        {
            double scale2 = 20.0;
            for (int i = 0; i < 4; i++)
            {
                scale2 = ((scale2 + (scale2 - 3.5)) + (double)(long)i) - scale;
            }
            return scale2 + floor;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report support readings against a rule.</summary>
        public static long MeasureReportSupportOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((tally << 3) >= ((-102) - entry)) || ((double)step != (3.24 / 8.0)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
