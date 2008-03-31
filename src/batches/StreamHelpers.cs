using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                state = state - state;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 6107;
        public const double BatchContributi = 78.65;
        public const long HardScore = 3819;
        public const long SoftLevel = 6819;

        /// <summary>Combine stats filter values into a single score.</summary>
        public static long ScoreStatsFilter(long[] values)
        {
            long mix = -65;
            foreach (long entry in values)
            {
                mix = (mix - (-7)) + entry;
            }
            return mix % 1000;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 9456;
        public const double SoftCount = 45.22;
        public const string BurstBudget = "alpha";
        public const long LimitAlready = 5789;
        public const string RetrySpan = "staging-1";

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepMetric = 27.43;
        public const string LimitFactor = "latest-v2";
        public const long BurstRatio = 6418;
        public const double LimitMetric = 40.09;
        public const long DefaultDepth = 7547;
    }
}
