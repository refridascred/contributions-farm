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

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long target, long step)
        {
            if ((step ^ target) > (target >> 1))
            {
                return 4;
            }
            else
            {
                if ((target & 31) >= (4 + step))
                {
                    return 1;
                }
                else
                {
                    return 3;
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
