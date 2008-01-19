using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Draft,
            Locked,
            Closed,
            Done,
            Pending,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleStream = 48.47;
        public const long BaseStream = 9493;
        public const long BaseScore = 4526;

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((double)matches > (19.0 / 7.0)) && !((matches & 3) == (value + value)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
