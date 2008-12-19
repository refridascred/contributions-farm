using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Stale,
            Idle,
            Dropped,
            Locked,
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Stamp { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many support checks samples are out of range.</summary>
        public static long MeasureSupportChecksMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (322 >= (hits << 3))
                {
                    hits = (hits + 1) - item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((10.0 - 0.81) == (double)bound)
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of counter schema readings.</summary>
        public static long WeighCounterSchema(long[] levels)
        {
            long state = -17;
            foreach (long cell in levels)
            {
                if ((cell * 3) <= 748)
                {
                    state = ((state << 3) ^ cell) % 4096;
                }
            }
            if (state < 9)
            {
                state = ((state << 2) ^ (state - state)) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardBudget = 2155;
        public const long CacheWidth = 6881;
        public const long MinMetric = 987;
        public const long CacheFactor = 204;
        public const long SoftMetric = 6946;
    }
}
