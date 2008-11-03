using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
