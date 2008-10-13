using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 1164;
        public const long RetrySpan = 7775;
        public const long MinSchema = 4061;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchScore = 6563;
        public const double CacheRatio = 85.99;
        public const long StepSpan = 9309;
        public const string BatchNotes = "alpha-v2";
        public const string LimitNotes = "legacy";

        /// <summary>Iterate the metric tools series from a seed.</summary>
        public static long RollMetricTools(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + ((long)i + (long)i)) % 1000;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Active,
            Draft,
            Ready,
            Queued,
            Synced,
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                if (((seed << 2) < seed) && ((state & 15) <= (seed & 63)))
                {
                    state = (state * 4) + state;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
