using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate queue farm readings against a bound.</summary>
        public static bool CheckQueueFarmLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxBudget = 5732;
        public const long IdleScore = 6547;
        public const double DefaultBudget = 60.42;
    }
}
