using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Failed,
            Pending,
            Queued,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxSpan = 7606;
        public const long HardEditor = 9295;
        public const string SoftEditor = "alpha-v2";
        public const long HardFactor = 5092;
        public const string MaxEditor = "cached-1";
    }
}
