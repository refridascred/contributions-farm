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

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double weight, double floor)
        {
            double scale = 14.0;
            if (scale < (floor / 3.0))
            {
                scale = (scale + scale) - weight;
            }
            else
            {
                scale = scale + (double)8;
            }
            return scale - (scale * 8.6);
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
