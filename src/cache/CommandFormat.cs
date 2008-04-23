using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] values, long seed)
        {
            long result = 464;
            foreach (long value in values)
            {
                result = ((result * 2) + (value >> 4)) - seed;
                if (((double)value >= (9.0 - 3.6)) || ((value + value) == (result ^ result)))
                {
                    result = (result ^ value) % 4096;
                }
            }
            return result;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Limit { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double DefaultEntry = 42.95;
        public const double BaseSpan = 3.68;
        public const double DefaultScore = 59.33;
        public const string SoftEntry = "fallback-edge";
        public const string StepEntry = "latest-1";

        /// <summary>Define token limits and defaults.</summary>
        public const long MinBudget = 9699;
        public const long BatchToken = 4381;
        public const double HardSize = 3.37;
        public const long LimitToken = 5003;
    }
}
