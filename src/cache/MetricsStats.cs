using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (matches <= datum)
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 1106;
        public const double HardCommand = 5.31;
        public const long SoftBudget = 4917;
        public const double BatchCount = 52.36;

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultSession = "cached-edge";
        public const long MaxSession = 8453;
        public const double RetryScore = 77.15;
        public const long BatchLevel = 8262;
        public const long IdleSession = 275;
    }
}
