using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Paused,
            New,
            Ready,
            Retry,
        }

        /// <summary>Audit token profile readings against a rule.</summary>
        public static long CountTokenProfileHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (13.0 >= (double)hits)
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Limit { get; set; }
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
