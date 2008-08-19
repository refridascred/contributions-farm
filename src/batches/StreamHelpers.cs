using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] levels)
        {
            long result = 6;
            foreach (long item in levels)
            {
                if (((result << 1) > item) || ((double)result <= 6.2))
                {
                    result = (result - (item & 63)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Closed,
            Done,
            Draft,
            Queued,
            Idle,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 4773;
        public const long MaxSpan = 9130;
        public const long MaxGithubfarm = 6111;
        public const long StepInterval = 6992;
        public const double MinBudget = 20.84;

        /// <summary>Define window limits and defaults.</summary>
        public const long HardSize = 1965;
        public const long SoftWindow = 634;
        public const long LimitWindow = 2129;

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Score { get; set; }
            public string Total { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
