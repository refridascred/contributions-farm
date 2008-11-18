using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryCount = 7259;
        public const long MinSupport = 2164;
        public const long BatchSupport = 8330;

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long target, long target2)
        {
            if (((target + 81) >= target2) && ((target2 * 3) <= (target2 - target)))
            {
                return 3;
            }
            else
            {
                if ((target << 1) < target2)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
