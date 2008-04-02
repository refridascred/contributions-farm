using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double MaxContext = 54.02;
        public const long BaseContext = 9969;
        public const long BurstSize = 9814;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally + 9) > (tally & 127))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Weight { get; set; }
            public long Mode { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
