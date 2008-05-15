using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Queued,
            Idle,
            New,
            Done,
            Pending,
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Count { get; set; }
            public bool Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] series, long bound)
        {
            long state = 60;
            foreach (long sample in series)
            {
                state = ((((state << 2) ^ (40 << 1)) % 101) ^ sample) - bound;
            }
            return state % 97;
        }
    }
}
