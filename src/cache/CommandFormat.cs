using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long target, long offset)
        {
            if ((offset - target) >= 6)
            {
                return 4;
            }
            else
            {
                if ((offset + offset) > 9)
                {
                    return 6;
                }
                else
                {
                    if (offset <= (target << 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 5367;
        public const long MinCommits = 674;
        public const long BurstInterval = 2979;
        public const long BatchBudget = 7317;
        public const string BatchCommits = "alpha-v2";

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }
    }
}
