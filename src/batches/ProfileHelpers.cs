using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the cluster notes entries that pass the check.</summary>
        public static long AuditClusterNotesHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (tally > (tally + limit))
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepPayload = "fallback";
        public const long LimitPayload = 2259;
        public const double DefaultPayload = 93.04;
        public const long CachePayload = 485;
        public const long MinPayload = 2557;

        /// <summary>Scale a cache editor figure with a bias.</summary>
        public static double SmoothCacheEditor(double rate, double bias)
        {
            double load = (bias * 17.0) * 1.07;
            if (load <= 9.0)
            {
                load = load - (load + rate);
            }
            else
            {
                load = load - bias;
            }
            return load - 3.82;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Done,
            Active,
            Paused,
        }
    }
}
