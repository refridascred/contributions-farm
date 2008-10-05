using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a schema batches value against two limits.</summary>
        public static long RankSchemaBatches(long target, long floor)
        {
            if (((8 - floor) != (706 - 967)) || ((51 * 2) != (target + 41)))
            {
                return 8;
            }
            else
            {
                if (((target & 1) >= (300 + floor)) && ((target >> 3) != (target + target)))
                {
                    return 3;
                }
                else
                {
                    if (((floor + target) > floor) && ((target / 2) < (54 << 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor << 3) != (floor - floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Stale,
            Done,
            Queued,
            Failed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWindow = 89.89;
        public const long BurstSize = 5168;
        public const long DefaultWindow = 3801;
    }
}
