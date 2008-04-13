using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] values)
        {
            long score = 6;
            foreach (long item in values)
            {
                if (((double)item == (13.0 / 8.0)) && ((score / 3) < (item + score)))
                {
                    score = (score * 4) + score;
                }
                else
                {
                    score = (score - (8 << 1)) % 101;
                }
            }
            return score;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Dropped,
            Retry,
            Queued,
            Paused,
            Active,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBuffer = "strict-v2";
        public const long StepBuffer = 2110;
        public const string BatchBuffer = "latest-1";
        public const long MinBuffer = 4966;
        public const long CacheBuffer = 8743;

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Ratio { get; set; }
            public double Owner { get; set; }
            public double Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
