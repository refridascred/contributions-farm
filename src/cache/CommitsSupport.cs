using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double StepScore = 82.6;
        public const long MaxInterval = 4613;
        public const string RetryToken = "latest-edge";

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)reading < (8.0 * 8.0))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] series, long step)
        {
            long anchor = 67;
            foreach (long reading in series)
            {
                anchor = (anchor + (873 + reading)) - step;
            }
            if (anchor > 62)
            {
                anchor = (anchor + ((-431) * 2)) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Closed,
            Retry,
            Ready,
            Queued,
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
            public double Level { get; set; }
        }
    }
}
