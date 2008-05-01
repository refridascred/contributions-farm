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

        /// <summary>Iterate the entry graph series from a seed.</summary>
        public static long DeriveEntryGraph(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 7; i++)
            {
                if (((floor - floor) < ((long)i + floor)) && ((double)sum <= (13.0 - 4.0)))
                {
                    sum = (sum << 3) ^ (sum - sum);
                }
                sum = ((sum << 3) ^ (long)i) % 255;
                sum = (sum + (sum * 3)) % 1000;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
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
