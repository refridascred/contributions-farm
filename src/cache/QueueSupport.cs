using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Label { get; set; }
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Idle,
            Retry,
            Locked,
            Draft,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)sample != (3.08 * 2.4))
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }
    }
}
