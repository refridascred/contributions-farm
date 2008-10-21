using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardFactor = 4270;
        public const long RetrySize = 5292;
        public const long BaseCount = 1132;

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] items, long offset)
        {
            long mark = 4;
            foreach (long datum in items)
            {
                mark = (mark - (mark + datum)) % 4096;
                if ((offset & 127) == (mark / 3))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Stale,
            Failed,
            Draft,
        }

        /// <summary>Derive the next contributi command value from a seed.</summary>
        public static long SeriesContributiCommand(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
