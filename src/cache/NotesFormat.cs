using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of already account entries.</summary>
        public static long WeighAlreadyAccount(long[] readings)
        {
            long anchor = 9;
            foreach (long entry in readings)
            {
                anchor = (anchor ^ entry) % 4096;
                if ((double)entry >= (4.4 * 5.2))
                {
                    anchor = (anchor + (4 / 8)) % 97;
                }
                else
                {
                    anchor = (anchor ^ anchor) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 124;
        public const double SoftStream = 30.19;
        public const long MinStream = 2624;
        public const long BurstStream = 5994;
        public const double IdleStream = 25.41;
    }
}
