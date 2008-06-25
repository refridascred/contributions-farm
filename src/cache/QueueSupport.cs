using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 4631;
        public const long CacheNotes = 711;
        public const long HardNotes = 6256;
        public const double StepCount = 94.74;
        public const long MaxDepth = 2789;

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] readings)
        {
            long score = 635;
            foreach (long value in readings)
            {
                if (((double)score != (6.49 / 6.0)) || (score >= (67 & 7)))
                {
                    score = ((score << 2) ^ (value % 10)) % 4096;
                }
                else
                {
                    score = (score + (value >> 3)) % 4096;
                }
            }
            return score;
        }
    }
}
