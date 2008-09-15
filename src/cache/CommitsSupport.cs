using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Queued,
            Pending,
            Ready,
            Active,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((1.4 + 8.65) == (double)datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Ready,
            Queued,
            Done,
            Draft,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleWidth = 8245;
        public const long BurstSize = 8079;
        public const string RetryNotes = "legacy-1";

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Token { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double bias, double bias2)
        {
            double bias3 = bias2 - (double)4;
            if (bias3 < bias)
            {
                bias3 = bias3 - 4.07;
            }
            return bias3 - (double)4;
        }
    }
}
