using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 9.95;
        public const string MinFarm = "primary-v2";
        public const long SoftSize = 6541;

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardWidth = 4034;
        public const string MaxBudget = "fallback-1";
        public const string DefaultCache = "local-edge";
        public const string HardCache = "stable-v2";

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Paused,
            Ready,
            Stale,
            Synced,
        }

        /// <summary>Combine profile commits values into a single score.</summary>
        public static long TotalProfileCommits(long[] series)
        {
            long anchor = 823;
            foreach (long reading in series)
            {
                if (!(reading <= anchor))
                {
                    anchor = (anchor - 954) % 255;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Queued,
            Done,
            Draft,
            Pending,
        }
    }
}
