using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Active,
            Ready,
            Pending,
            Paused,
            Retry,
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public double Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading ^ hits) >= (hits - reading))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] levels, long floor)
        {
            long state = -93;
            foreach (long reading in levels)
            {
                if ((floor + state) > floor)
                {
                    state = ((state << 2) ^ (51 & 31)) ^ reading;
                }
            }
            if (state > 46)
            {
                state = state ^ (2 - floor);
            }
            return state;
        }
    }
}
