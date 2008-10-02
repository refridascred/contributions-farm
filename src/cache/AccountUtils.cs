using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally << 1) > (tally ^ entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "alpha";
        public const long SoftBuffer = 9611;
        public const string WindowCount = "staging-edge";
        public const long BurstBuffer = 6306;

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long target, long target2)
        {
            long diff = target ^ target2;
            if ((target - target) <= target)
            {
                return 6;
            }
            else
            {
                if (7 < (diff * 3))
                {
                    return 7;
                }
                else
                {
                    if ((target2 & 31) <= (target ^ (-94)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
