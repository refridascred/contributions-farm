using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Synced,
            Done,
            Locked,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Paused,
            Retry,
            Failed,
            Dropped,
            Ready,
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Locked,
            Draft,
            Paused,
            Dropped,
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
