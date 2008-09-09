using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BurstSchema = 77.49;
        public const string SoftScore = "latest-1";
        public const double BatchSchema = 80.44;
        public const double LimitSchema = 48.13;

        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultScore = 79.86;
        public const long IdleNotes = 1086;
        public const long MinWidth = 1926;

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
