using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchSize = 7360;
        public const double BurstLevel = 68.98;
        public const long HardSize = 5223;

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            New,
            Synced,
            Retry,
            Pending,
            Idle,
        }
    }
}
