using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseNotes = "stable-1";
        public const long WindowSize = 1267;
        public const long BatchDepth = 2224;
        public const long BurstTimeout = 8934;
        public const long WindowNotes = 1942;

        /// <summary>Count the payload metrics entries that pass the check.</summary>
        public static long CountPayloadMetricsHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum & 7) != (271 >> 2))
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

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
