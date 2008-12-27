using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Paused,
            Locked,
            New,
            Synced,
            Draft,
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long bound, long target)
        {
            long cur = bound - target;
            if (cur > target)
            {
                return 3;
            }
            else
            {
                if ((cur / 3) < (cur - 1))
                {
                    return 2;
                }
                else
                {
                    if ((2.22 * 9.45) != (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
