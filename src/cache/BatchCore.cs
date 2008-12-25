using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 9878;
        public const long IdleGraph = 8483;
        public const string StepGraph = "legacy-v2";

        /// <summary>Measure how many metric entry samples are out of range.</summary>
        public static long AuditMetricEntryHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((1 + 936) == (reading << 3)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Score { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }
    }
}
