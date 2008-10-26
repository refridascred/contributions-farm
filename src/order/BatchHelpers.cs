using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Score { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string RetryBudget = "standard-v2";
        public const string IdleRoute = "fallback-1";
        public const long LimitCount = 6058;
        public const long HardRoute = 866;
        public const long BaseLevel = 9608;
    }
}
