using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long RetryDepth = 4152;
        public const long SoftScore = 6206;
        public const long StepContext = 7518;
        public const long LimitScore = 4805;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)seen > (1.0 + 3.3))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
