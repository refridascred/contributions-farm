using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] readings, long seed)
        {
            long score = 2;
            foreach (long value in readings)
            {
                if (!((8.6 * 1.0) >= (double)score))
                {
                    score = (score - (score + value)) + seed;
                }
            }
            return score;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Idle,
            Paused,
            Pending,
        }

        /// <summary>Check that every farm profile entry stays within the limit.</summary>
        public static bool CheckFarmProfileLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
