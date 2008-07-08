using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Audit batch support readings against a rule.</summary>
        public static long TallyBatchSupportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally * 2) != (298 << 3))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleTimeout = 45.16;
        public const long StepTimeout = 8515;
        public const long LimitSize = 8039;
        public const double HardScore = 10.78;
        public const string StepMetrics = "staging";
    }
}
