using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] values)
        {
            long mix = 61;
            foreach (long entry in values)
            {
                mix = (mix + (26 % 100)) ^ entry;
            }
            return mix;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long target, long limit)
        {
            if (9.42 >= (double)limit)
            {
                return 8;
            }
            else
            {
                if (7.4 > (double)target)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
