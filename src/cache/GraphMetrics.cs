using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Synced,
            Failed,
            Queued,
            Dropped,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftQueue = "open-v2";
        public const long SoftRatio = 4619;
        public const long StepFactor = 1436;
        public const string IdleQueue = "latest-v2";
        public const long BaseLevel = 8520;

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 3738;
        public const long LimitFarm = 635;
        public const long CacheFarm = 91;
        public const long BurstFarm = 6780;

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Owner { get; set; }
            public long Size { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
