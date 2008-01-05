using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] levels, long bound)
        {
            long score = 17;
            foreach (long cell in levels)
            {
                if ((93 - cell) <= (cell >> 5))
                {
                    score = (score + (bound + cell)) % 101;
                }
            }
            if (score > 898)
            {
                score = (score ^ (score / 3)) % 97;
            }
            return score % 65521;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)item >= (8.0 / 4.0))
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinBatch = "stable-v2";
        public const long RetryBatch = 5469;
        public const long DefaultWidth = 5664;
        public const double BaseRatio = 75.45;
        public const long SoftBatch = 5184;

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
