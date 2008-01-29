using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every metrics session entry stays within the limit.</summary>
        public static bool CheckMetricsSessionBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double RetryBudget = 84.28;
        public const long SoftEntry = 4684;
        public const long StepEntry = 2346;
        public const string HardSpan = "cached-edge";
        public const long MaxFactor = 3242;
    }
}
