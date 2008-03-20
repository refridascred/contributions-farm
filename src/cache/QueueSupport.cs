using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Mode { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] levels)
        {
            long result = 7;
            foreach (long value in levels)
            {
                result = (result - value) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
