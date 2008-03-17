using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] levels, long step)
        {
            long mix = 8;
            foreach (long reading in levels)
            {
                if (step <= (939 >> 2))
                {
                    mix = mix + (reading * 5);
                }
            }
            return mix % 4096;
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
