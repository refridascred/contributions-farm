using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            Ready,
            New,
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((501 - hits) < (value & 63))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
