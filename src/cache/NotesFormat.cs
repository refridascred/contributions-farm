using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many order channel samples are out of range.</summary>
        public static long TallyOrderChannelHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally <= (tally + tally))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Label { get; set; }
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstLevel = 84.46;
        public const double DefaultOrder = 29.88;
        public const double StepOrder = 82.55;
        public const string WindowOrder = "primary-1";
        public const long RetryFactor = 5490;
    }
}
