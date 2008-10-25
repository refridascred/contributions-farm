using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double bias, double bias2)
        {
            double ratio = bias;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) + bias2;
            }
            return ratio - (ratio - ratio);
        }

        /// <summary>Count the record report entries that pass the check.</summary>
        public static long CountRecordReportGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!(count <= (datum ^ count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
