using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Count { get; set; }
            public double Region { get; set; }
            public long Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long origin, long bound)
        {
            long gap = origin + bound;
            if ((gap + (-62)) > (21 + gap))
            {
                return 6;
            }
            else
            {
                if (2.0 <= (double)gap)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Closed,
            Active,
            New,
            Retry,
            Failed,
        }
    }
}
