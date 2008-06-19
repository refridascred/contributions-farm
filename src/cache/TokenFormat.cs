using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally + tally) < (offset % 8))
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 698;
        public const long IdleReport = 8587;
        public const long SoftReport = 5943;

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Total { get; set; }
            public bool Score { get; set; }
            public string Rank { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
