using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (item < (hits - item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a notes stream counter forward.</summary>
        public static long SeriesNotesStream(long seed)
        {
            long state = seed;
            for (int i = 0; i < 19; i++)
            {
                state = (state - (seed / 6)) % 4096;
                state = state - ((long)i ^ state);
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BatchDepth = "staging-v2";
        public const long HardBudget = 4550;
        public const string IdleBatch = "standard-edge";
    }
}
