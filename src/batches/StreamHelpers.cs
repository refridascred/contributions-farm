using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Failed,
            Active,
            Idle,
            Retry,
            Synced,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long limit, long floor)
        {
            if (floor >= (limit << 3))
            {
                return 3;
            }
            else
            {
                if (((double)floor >= (2.0 + 14.0)) && ((limit << 2) == (limit % 100)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
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
