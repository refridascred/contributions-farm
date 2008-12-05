using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every editor route entry stays within the limit.</summary>
        public static bool GuardEditorRouteBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Ready,
            Locked,
            New,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitCount = 7182;
        public const long MaxRatio = 1187;
        public const long BurstAlready = 5207;
        public const long IdleSpan = 684;
    }
}
