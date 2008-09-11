using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 6486;
        public const string IdleWidth = "primary-1";
        public const double StepContext = 0.68;
        public const long MaxContext = 9940;

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Paused,
            Active,
            Queued,
            Synced,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] samples)
        {
            long sum = 9;
            foreach (long value in samples)
            {
                sum = (sum + (value & 127)) % 4096;
                if ((sum / 2) <= value)
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Count format editor pairs that satisfy a relation.</summary>
        public static long OverlapFormatEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Failed,
            New,
            Idle,
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Region { get; set; }
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public double Mode { get; set; }
        }
    }
}
