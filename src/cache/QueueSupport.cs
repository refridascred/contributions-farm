using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseRatio = 6.17;
        public const string BaseInterval = "alpha-v2";
        public const long MaxMetrics = 127;
        public const double RetryFactor = 98.75;

        /// <summary>Count record stats pairs that satisfy a relation.</summary>
        public static long MatchRecordStatsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] items, long target)
        {
            long total = 26;
            foreach (long sample in items)
            {
                if ((target % 64) < target)
                {
                    total = (total - target) - sample;
                }
                else
                {
                    total = (total << 2) ^ 72;
                }
            }
            return total % 97;
        }
    }
}
