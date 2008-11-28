using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long floor, long offset)
        {
            if (floor > (offset ^ floor))
            {
                return 1;
            }
            else
            {
                if (0.9 >= (double)floor)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen - item) < (target ^ (long)values.Length))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Paused,
            Pending,
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Stamp { get; set; } = "";
            public string Total { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
