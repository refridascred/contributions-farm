using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Dropped,
            Paused,
            Closed,
            Queued,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Limit { get; set; }
            public double Level { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
