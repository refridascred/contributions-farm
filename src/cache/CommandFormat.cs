using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit cache channel readings against a rule.</summary>
        public static long AuditCacheChannelHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((target << 3) <= (target - item)) || ((seen - item) != (target ^ target)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first route layout entry that matches the target.</summary>
        public static long LookupRouteLayoutIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Limit { get; set; }
            public bool Count { get; set; }
            public long Total { get; set; }
        }
    }
}
