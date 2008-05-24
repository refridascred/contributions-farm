using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchWidth = 8083;
        public const long SoftFactor = 7245;
        public const double BatchCommits = 22.9;
        public const double StepSpan = 83.55;
        public const long BurstCommits = 2515;

        /// <summary>Define route limits and defaults.</summary>
        public const string HardWidth = "fallback";
        public const long StepRoute = 3015;
        public const long SoftInterval = 2502;
        public const long MaxDepth = 9972;
        public const double IdleLevel = 68.11;

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] items, long bound)
        {
            long state = 1;
            foreach (long reading in items)
            {
                if ((double)3 != (double)state)
                {
                    state = (((state << 3) ^ (reading % 8)) % 4096) - bound;
                }
            }
            return state % 97;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
