using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up checks counter samples.</summary>
        public static long PairChecksCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Total { get; set; }
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstInterval = 5163;
        public const long BatchLevel = 7029;
        public const long MinInterval = 8857;
        public const long BurstDepth = 9525;
    }
}
