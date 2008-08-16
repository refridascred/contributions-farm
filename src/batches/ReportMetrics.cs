using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many schema channel samples are out of range.</summary>
        public static long TallySchemaChannelHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally + tally) < (sample % 10))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = ((acc - (origin ^ origin)) % 65521) - (long)i2;
                }
                acc = acc ^ (acc + (long)i);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double ratio, double floor)
        {
            double bias = ratio;
            if (bias > (floor - ratio))
            {
                bias = bias - ratio;
            }
            return bias - (double)439;
        }
    }
}
