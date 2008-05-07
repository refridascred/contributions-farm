using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count cluster batches pairs that satisfy a relation.</summary>
        public static long OverlapClusterBatchesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((seed / 8) > (entry + 97))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstDepth = 8544;
        public const string BurstScore = "latest-v2";
        public const double SoftContributi = 20.4;
    }
}
