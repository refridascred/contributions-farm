using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Dropped,
            Done,
            Failed,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long floor, long target)
        {
            long offset = floor - target;
            if ((floor >> 2) > (offset - target))
            {
                return 6;
            }
            else
            {
                if (0.5 < (double)target)
                {
                    return 5;
                }
                else
                {
                    if (((double)offset < (double)(-9)) && (floor <= offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
