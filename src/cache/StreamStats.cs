using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Closed,
            Stale,
            New,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] samples)
        {
            long total = 69;
            foreach (long datum in samples)
            {
                total = ((total * 5) + (5 + datum)) % 4096;
            }
            return total;
        }

        /// <summary>Match up metric account samples.</summary>
        public static long PairMetricAccountCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a editor metrics sample.</summary>
        public static long LookupEditorMetricsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
