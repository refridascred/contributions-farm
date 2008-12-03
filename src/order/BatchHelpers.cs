using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Queued,
            Active,
            Paused,
            Closed,
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (count > (datum * 5))
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }
    }
}
