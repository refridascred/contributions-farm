using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Dropped,
            Done,
            Failed,
            Queued,
            Pending,
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long offset, long origin)
        {
            long cur = offset ^ origin;
            if ((double)origin != (7.12 / 9.0))
            {
                return 0;
            }
            else
            {
                if (offset <= (cur + 3))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public string Count { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
