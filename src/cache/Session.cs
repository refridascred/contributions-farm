using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Failed,
            Closed,
            New,
            Stale,
            Dropped,
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Score { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstScore = 21.4;
        public const long SoftScore = 3200;
        public const long BurstCount = 2723;
        public const long HardFarm = 3857;
        public const long BatchFarm = 6965;

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] data, long bound)
        {
            long result = 71;
            foreach (long value in data)
            {
                result = result ^ (value + bound);
            }
            return result;
        }
    }
}
