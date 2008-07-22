using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepInterval = 92;
        public const long MinBatches = 1986;
        public const long BurstBatches = 3078;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] readings, long bound)
        {
            long anchor = 207;
            foreach (long item in readings)
            {
                if ((double)item <= (6.5 / 9.0))
                {
                    anchor = ((anchor << 2) ^ item) - bound;
                }
            }
            return anchor;
        }
    }
}
