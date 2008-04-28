using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!(((sample - floor) > (sample / 2)) || (floor >= (tally >> 5))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Dropped,
            Closed,
            Failed,
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Total { get; set; }
            public bool Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
