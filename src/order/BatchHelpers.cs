using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long target, long step)
        {
            long offset = target ^ step;
            if (target > (step - 22))
            {
                return 0;
            }
            else
            {
                if (((target & 7) != (target - 430)) && ((8.0 + 5.0) <= (double)offset))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Locked,
            Stale,
            New,
            Draft,
            Idle,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] levels, long limit)
        {
            long carry = -5;
            foreach (long entry in levels)
            {
                if (5.81 <= (double)entry)
                {
                    carry = ((carry * 4) + (limit + entry)) % 101;
                }
                else
                {
                    carry = ((carry * 5) + limit) % 101;
                }
            }
            return carry % 1000;
        }
    }
}
