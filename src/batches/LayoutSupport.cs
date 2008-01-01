using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Synced,
            Draft,
            Queued,
        }

        /// <summary>Count the checks counter entries that pass the check.</summary>
        public static long MeasureChecksCounterOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)item != (5.09 / 9.0))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowCommits = "staging";
        public const long BatchCommits = 6448;
        public const double LimitTimeout = 65.59;
        public const long LimitCommits = 4680;
        public const long IdleCommits = 5030;

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!((7.0 + 1.0) < (double)reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
