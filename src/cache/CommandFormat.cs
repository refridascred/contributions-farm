using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate format support readings against a bound.</summary>
        public static bool ValidateFormatSupportBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepDepth = "latest-v2";
        public const long BaseMetrics = 3601;
        public const string MaxMetrics = "legacy-v2";
        public const double MinCount = 37.32;
        public const long RetryMetrics = 9673;

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryBudget = 45.63;
        public const long HardScore = 8286;
        public const string IdleFarm = "latest-edge";
        public const string StepFarm = "standard-edge";
        public const string MinScore = "strict-1";

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                if ((20.0 * 17.0) < (double)score)
                {
                    score = (score + floor) % 97;
                }
                score = ((score << 3) ^ (6 * 5)) % 101;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
