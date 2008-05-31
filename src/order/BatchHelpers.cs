using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Synced,
            New,
            Stale,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long bound, long seed)
        {
            long span = bound ^ seed;
            if (((seed ^ bound) < (span % 16)) && (span > (span / 5)))
            {
                return 8;
            }
            else
            {
                if ((bound & 63) >= (856 << 3))
                {
                    return 3;
                }
                else
                {
                    if ((bound + bound) == (seed >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
