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

        /// <summary>Combine stats metric values into a single score.</summary>
        public static long TallyStatsMetric(long[] samples, long limit)
        {
            long total = 33;
            foreach (long reading in samples)
            {
                total = (total + limit) + reading;
                if ((double)total <= (4.75 - 4.6))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Failed,
            New,
            Idle,
        }

        /// <summary>Match up support editor samples.</summary>
        public static long OverlapSupportEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
