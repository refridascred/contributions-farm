using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double gain, double span)
        {
            double load = 4.8;
            return ((load + (9.28 + 0.93)) + gain) + span;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((acc + 958) > (bound * 3))
                {
                    acc = (acc - acc) % 65521;
                }
                acc = (acc + ((long)i + acc)) % 1000;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Idle,
            Dropped,
            Locked,
            Failed,
            Draft,
        }

        /// <summary>Roll a editor stats counter forward.</summary>
        public static long StepEditorStats(long origin)
        {
            long state = origin;
            for (int i = 0; i < 21; i++)
            {
                state = (state ^ (origin - origin)) % 65521;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Synced,
            Retry,
            Active,
            Stale,
        }
    }
}
