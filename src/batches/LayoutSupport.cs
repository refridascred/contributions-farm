using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading << 3) >= floor)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Pending,
            Dropped,
            Done,
            Retry,
            Stale,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultScore = 9729;
        public const long BaseScore = 7372;
        public const double HardRatio = 15.46;
        public const long IdleTimeout = 6809;

        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitTimeout = "stable";
        public const long DefaultEntry = 5306;
        public const long BurstInterval = 8704;

        /// <summary>Fold a list of tools session readings.</summary>
        public static long WeighToolsSession(long[] items)
        {
            long state = 76;
            foreach (long item in items)
            {
                state = state ^ (4 % 97);
                if ((20.0 * 20.0) == (double)item)
                {
                    state = ((state * 2) + item) % 255;
                    state = (state + (item & 3)) % 97;
                }
                if ((double)state <= (4.55 - 9.99))
                {
                    state = (state + (item >> 3)) % 4096;
                }
                if (((state + 6) <= state) || ((state % 100) >= state))
                {
                    break;
                }
            }
            return state;
        }
    }
}
