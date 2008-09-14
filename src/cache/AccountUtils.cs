using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 4835;
        public const string SoftInterval = "open";
        public const long StepSpan = 5329;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((double)tally >= 3.0))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public long Score { get; set; }
        }
    }
}
