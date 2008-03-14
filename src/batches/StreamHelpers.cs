using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate cluster editor readings against a bound.</summary>
        public static bool GuardClusterEditorBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Paused,
            Idle,
            Locked,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] values)
        {
            long state = 904;
            foreach (long value in values)
            {
                if (!((double)value > (double)state))
                {
                    state = (state ^ (value & 63)) % 1000;
                }
                if ((value + 911) <= value)
                {
                    state = ((state << 2) ^ (state - state)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Draft,
            Ready,
            Dropped,
            Queued,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 310;
        public const double IdleTimeout = 71.98;
        public const long WindowCount = 7050;
        public const long HardBatches = 3486;

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxContext = "local-v2";
        public const long CacheLevel = 6095;
        public const double DefaultContext = 49.69;
        public const long IdleContext = 3721;
        public const double LimitContext = 70.79;
    }
}
