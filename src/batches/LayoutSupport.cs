using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Validate account token readings against a bound.</summary>
        public static bool CheckAccountTokenBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheLevel = 9174;
        public const long LimitLevel = 8842;
        public const long BurstCache = 6925;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Queued,
            Idle,
            New,
            Closed,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Pending,
            Queued,
            Stale,
            Active,
            Closed,
        }
    }
}
