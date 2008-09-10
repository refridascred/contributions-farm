using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Pending,
            Synced,
            Queued,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long limit, long offset)
        {
            if (9.5 >= (double)limit)
            {
                return 0;
            }
            else
            {
                if (((offset >> 1) <= limit) || ((offset + offset) == (113 * 5)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
            public bool Total { get; set; }
        }
    }
}
