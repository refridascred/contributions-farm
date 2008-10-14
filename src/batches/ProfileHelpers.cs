using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            Idle,
            Draft,
        }

        /// <summary>Count the entry window entries that pass the check.</summary>
        public static long CountEntryWindowGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)matches < 4.0)
                {
                    matches = ((matches + 3) - datum) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Idle,
            Stale,
            Done,
            Dropped,
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Score { get; set; }
            public bool Limit { get; set; }
            public bool Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] samples)
        {
            long score = 277;
            foreach (long reading in samples)
            {
                if (17 < reading)
                {
                    score = (score << 3) ^ (reading & 1);
                }
            }
            return score;
        }
    }
}
