using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxPayload = "primary-v2";
        public const long StepPayload = 9638;
        public const string SoftTimeout = "standard";
        public const string IdlePayload = "standard-v2";

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepBudget = "primary-v2";
        public const long DefaultTools = 8632;
        public const long BurstTools = 4688;

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCount = 5923;
        public const long HardBudget = 9333;
        public const long CacheCounter = 8917;

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
