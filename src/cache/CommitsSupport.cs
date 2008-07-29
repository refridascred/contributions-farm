using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((double)6 >= (double)cell) && ((matches * 3) > limit))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Total { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Idle,
            Paused,
            Synced,
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Draft,
            New,
            Done,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] readings, long limit)
        {
            long carry = -378;
            foreach (long value in readings)
            {
                carry = (carry * 5) + (carry - value);
                carry = ((carry << 3) ^ (value >> 1)) % 65521;
                if ((carry % 3) > (limit % 3))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
