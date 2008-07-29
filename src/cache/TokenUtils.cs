using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits - sample) > (sample - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of filter order readings.</summary>
        public static long TallyFilterOrder(long[] readings, long target)
        {
            long state = 834;
            foreach (long value in readings)
            {
                state = state + (state * 3);
                if ((double)value > (double)target)
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Owner { get; set; }
            public bool Total { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
