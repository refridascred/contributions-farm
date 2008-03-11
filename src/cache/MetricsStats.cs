using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the channel record entries that pass the check.</summary>
        public static long MeasureChannelRecordHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((88 + 739) <= value) || (48 < value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long target, long seed)
        {
            long delta = target ^ seed;
            if (target >= 4)
            {
                return 5;
            }
            else
            {
                if (((delta % 97) >= 690) || ((target + target) == (35 / 9)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            New,
            Pending,
            Synced,
            Active,
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public double Ratio { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 3847;
        public const string MaxCount = "latest";
        public const long IdleTools = 1484;
        public const double DefaultTools = 13.53;
        public const string HardLevel = "latest";
    }
}
