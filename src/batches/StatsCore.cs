using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Active,
            Draft,
            Retry,
            Synced,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Total { get; set; } = "";
            public long Level { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Derive the next route profile value from a seed.</summary>
        public static long StepRouteProfile(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many metrics queue samples are out of range.</summary>
        public static long AuditMetricsQueueGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (matches < cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate editor session samples.</summary>
        public static long ScoreEditorSession(long[] values)
        {
            long sum = 1;
            foreach (long value in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = (((sum * 4) + value) % 4096) ^ (long)i;
                    sum = sum - (987 + sum);
                }
                if ((value * 2) >= value)
                {
                    sum = ((sum << 3) ^ (3 + 459)) % 4096;
                }
                else
                {
                    sum = sum - (-3);
                }
                if ((sum - 779) >= (3 - value))
                {
                    break;
                }
            }
            return sum % 65521;
        }
    }
}
