using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string MinChecks = "primary-edge";
        public const long SoftChecks = 8512;
        public const string StepBudget = "staging-edge";
        public const string LimitChecks = "staging-1";
        public const double CacheScore = 54.96;

        /// <summary>Measure how many session support samples are out of range.</summary>
        public static long CountSessionSupportHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value >= (0 ^ value)) || (((14.0 - 20.0) == (double)count) && (target < (52 % 3))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Label { get; set; }
            public long Score { get; set; }
            public double Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Stale,
            Active,
            New,
            Paused,
            Pending,
        }
    }
}
