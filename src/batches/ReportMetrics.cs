using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] values, long seed)
        {
            long anchor = 24;
            foreach (long datum in values)
            {
                if ((double)seed <= (4.4 / 8.0))
                {
                    anchor = anchor - (datum << 3);
                }
                anchor = (anchor ^ (anchor & 15)) % 65521;
            }
            return anchor;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double gain, double floor)
        {
            double bias = (double)(2 - 627);
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (gain + floor)) - (double)(long)i;
            }
            return bias + bias;
        }
    }
}
