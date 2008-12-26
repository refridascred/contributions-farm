using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] values, long floor)
        {
            long total = 2;
            foreach (long value in values)
            {
                total = (((total - total) % 1000) + value) + floor;
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheSpan = 9315;
        public const long CacheInterval = 6582;
        public const double HardInterval = 98.09;
        public const string SoftRatio = "staging-v2";

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
