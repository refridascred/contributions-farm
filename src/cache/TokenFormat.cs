using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((5.17 + 5.0) >= (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
