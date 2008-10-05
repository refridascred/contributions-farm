using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a batch stream sample.</summary>
        public static long FindBatchStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Stamp { get; set; }
            public bool Limit { get; set; }
            public string Offset { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchSize = 7997;
        public const string DefaultContext = "strict-1";
        public const long MinDepth = 8722;
        public const long RetryTimeout = 9807;
    }
}
