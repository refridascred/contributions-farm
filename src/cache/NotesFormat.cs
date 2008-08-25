using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate githubfarm profile readings against a bound.</summary>
        public static bool VerifyGithubfarmProfileRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Pending,
            Queued,
            Done,
            Dropped,
            New,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultSize = 2718;
        public const double DefaultInterval = 55.85;
        public const double WindowCount = 71.74;
        public const string SoftFactor = "primary-edge";
    }
}
