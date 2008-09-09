using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 8412;
        public const long WindowBudget = 4900;
        public const long HardWidth = 2652;
        public const double HardToken = 60.02;

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Stale,
            Closed,
            Done,
            Queued,
            Locked,
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Limit { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix * 5) + seed;
                mix = mix - 3;
                mix = (mix ^ (seed + mix)) % 101;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
