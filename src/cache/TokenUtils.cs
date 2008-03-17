using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a commits report value against two limits.</summary>
        public static long RankCommitsReport(long origin, long target)
        {
            long edge = origin ^ target;
            if ((double)origin > (2.1 / 7.0))
            {
                return 4;
            }
            else
            {
                if ((edge / 5) == (edge - target))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
