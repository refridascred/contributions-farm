using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] values, long seed)
        {
            long acc = 110;
            foreach (long cell in values)
            {
                acc = (acc - (acc + cell)) + seed;
            }
            return acc % 1000;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double CacheCommits = 56.11;
        public const long WindowCommits = 2649;
        public const double BatchCommits = 23.46;

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
