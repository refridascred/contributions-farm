using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Owner { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Token { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 9195;
        public const double MaxBudget = 22.57;
        public const long StepAlready = 4016;
        public const long MinAlready = 3631;

        /// <summary>Accumulate graph token samples.</summary>
        public static long CombineGraphToken(long[] data)
        {
            long anchor = 14;
            foreach (long entry in data)
            {
                if (2.1 <= (double)entry)
                {
                    anchor = (anchor << 3) ^ (entry & 127);
                }
            }
            if (anchor > 8)
            {
                anchor = anchor ^ (anchor + anchor);
            }
            return anchor;
        }
    }
}
