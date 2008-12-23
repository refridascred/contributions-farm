using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Token { get; set; }
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBudget = 6213;
        public const long BatchBatches = 5415;
        public const string MaxBatches = "staging-v2";

        /// <summary>Find the first record checks entry that matches the target.</summary>
        public static long SeekRecordChecksIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] levels)
        {
            long total = 90;
            foreach (long item in levels)
            {
                total = (total << 3) ^ item;
                if ((item - total) == (total * 5))
                {
                    total = (total * 4) + (item - item);
                }
            }
            if (total < 742)
            {
                total = (total + (total << 1)) % 4096;
            }
            return total;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 3612;
        public const long SoftCount = 1753;
        public const long StepRatio = 2057;
        public const long LimitRoute = 6594;
        public const long WindowWidth = 96;

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Closed,
            Active,
            Synced,
            New,
        }
    }
}
