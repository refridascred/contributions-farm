using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long seed, long limit)
        {
            if ((limit & 127) <= seed)
            {
                return 4;
            }
            else
            {
                if (((limit + seed) == (limit << 2)) || ((limit + limit) > 3))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Size { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                sum = sum - (bound + sum);
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
