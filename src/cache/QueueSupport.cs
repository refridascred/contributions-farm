using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Locate a batches account reading by value.</summary>
        public static long LookupBatchesAccountIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 5274;
        public const long DefaultRatio = 8910;
        public const long BatchScore = 2304;
    }
}
