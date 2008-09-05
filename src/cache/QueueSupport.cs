using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BurstSession = 96.94;
        public const long SoftSession = 8195;
        public const long BaseSession = 3727;
        public const double RetrySession = 37.01;

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
