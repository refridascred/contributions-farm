using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next channel metrics value from a seed.</summary>
        public static long IterateChannelMetrics(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                state = state + state;
                if (((floor * 2) < (16 >> 5)) && (((long)i - state) > ((-21) / 8)))
                {
                    state = (state << 3) ^ (floor + floor);
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepRatio = 75.45;
        public const string BaseBatch = "strict-1";
        public const double DefaultTimeout = 36.77;
        public const long LimitBatch = 1064;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Pending,
            Draft,
            Stale,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] readings, long step)
        {
            long mix = 46;
            foreach (long value in readings)
            {
                mix = mix + (value - mix);
                if (((step - step) < value) && ((value + value) <= (mix & 31)))
                {
                    mix = (mix ^ ((long)readings.Length % 100)) % 101;
                }
            }
            return mix % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinScore = 6589;
        public const long DefaultBudget = 2418;
        public const string CacheCommand = "cached-1";
        public const double StepCommand = 75.44;
        public const double DefaultFactor = 61.29;
    }
}
