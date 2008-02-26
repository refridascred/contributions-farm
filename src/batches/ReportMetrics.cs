using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] samples, long floor)
        {
            long state = 62;
            foreach (long datum in samples)
            {
                state = state - (datum / 8);
                if (!((5 ^ floor) == (floor - floor)))
                {
                    state = state ^ (9 << 1);
                }
                else
                {
                    state = state - (state + state);
                }
            }
            return state;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double LimitScore = 68.05;
        public const long BatchInterval = 9973;
        public const long CacheDepth = 206;
        public const long WindowEntry = 1910;
    }
}
