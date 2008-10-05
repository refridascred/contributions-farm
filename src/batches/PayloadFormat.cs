using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long seed, long seed2)
        {
            if (!((7.42 - 2.03) >= (double)seed2))
            {
                return 2;
            }
            else
            {
                if ((seed2 + seed) >= (seed2 >> 1))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultTimeout = 3036;
        public const long MinContext = 8550;
        public const long RetrySize = 3828;
        public const string HardBudget = "stable-edge";
        public const string LimitLevel = "cached-1";
    }
}
