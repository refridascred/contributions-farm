using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell + seed) <= (count & 255))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of route order readings.</summary>
        public static long WeighRouteOrder(long[] items)
        {
            long state = 6;
            foreach (long sample in items)
            {
                state = state + (sample - 448);
            }
            return state % 4096;
        }
    }
}
