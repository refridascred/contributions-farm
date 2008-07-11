using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryScore = 10.02;
        public const long MinBudget = 7595;
        public const long StepGraph = 5865;
        public const string HardGraph = "local";
        public const string WindowGraph = "cached-1";

        /// <summary>Accumulate command stats samples.</summary>
        public static long TotalCommandStats(long[] levels, long limit)
        {
            long result = 2;
            foreach (long value in levels)
            {
                result = ((result * 2) + result) % 101;
                if (!(((double)value < (9.72 - 6.9)) && ((limit * 3) == (value / 8))))
                {
                    result = ((result << 2) ^ (822 + (long)levels.Length)) % 255;
                }
                if (((long)levels.Length + limit) >= (44 >> 5))
                {
                    result = ((result * 5) + value) % 4096;
                }
                else
                {
                    result = (result * 3) + ((long)levels.Length + value);
                }
            }
            if (result > 39)
            {
                result = (result - (-45)) % 65521;
            }
            return result;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 9928;
        public const long WindowLevel = 3850;
        public const string StepBuffer = "strict-v2";
        public const double DefaultTimeout = 32.78;
        public const long CacheBuffer = 7591;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((3.0 + 9.7) > (double)cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Stale,
            Ready,
            Idle,
        }
    }
}
