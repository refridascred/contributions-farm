using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BaseTimeout = 8195;
        public const string MaxOrder = "local-edge";
        public const long CacheOrder = 3692;
        public const double LimitOrder = 96.35;

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Queued,
            Synced,
            New,
            Failed,
            Closed,
        }

        /// <summary>Match up contributi stream samples.</summary>
        public static long PairContributiStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
