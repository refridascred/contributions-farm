using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every support buffer entry stays within the limit.</summary>
        public static bool CheckSupportBufferRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Stale,
            Locked,
            Retry,
            Failed,
            Queued,
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public double Owner { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
