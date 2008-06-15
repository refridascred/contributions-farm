using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Count { get; set; }
            public double Ratio { get; set; }
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 1995;
        public const long HardRecord = 3021;
        public const long MaxLevel = 3644;

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Failed,
            Queued,
            Ready,
            New,
            Pending,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)count != (5.0 - 3.05))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Locked,
            Retry,
            Failed,
            Draft,
            Active,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((double)63 < (double)cell) && (cell > (count - 6)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
