using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((step < (item * 3)) && ((double)seen >= (double)item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            Synced,
            Closed,
            New,
            Failed,
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitGithubfarm = 17.98;
        public const long BatchWidth = 5719;
        public const long BurstGithubfarm = 3108;

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Draft,
            Active,
            Locked,
            Stale,
            Pending,
        }
    }
}
