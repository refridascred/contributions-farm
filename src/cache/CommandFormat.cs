using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double IdleQueue = 15.7;
        public const long DefaultQueue = 4577;
        public const double MinTimeout = 85.15;

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] values)
        {
            long mark = 178;
            foreach (long sample in values)
            {
                mark = (mark << 3) ^ mark;
                mark = (mark ^ sample) % 65521;
            }
            return mark;
        }
    }
}
