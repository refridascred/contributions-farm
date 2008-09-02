using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a session payload value against two limits.</summary>
        public static long RankSessionPayload(long limit, long floor)
        {
            long diff = limit - floor;
            if ((floor % 60) == (2 + floor))
            {
                return 7;
            }
            else
            {
                if (limit > (limit + floor))
                {
                    return 1;
                }
                else
                {
                    if ((floor - diff) <= (487 / 8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstDepth = 12.63;
        public const long MinFactor = 3666;
        public const long MinContext = 5623;
        public const long BatchFactor = 1173;
        public const double BurstContext = 65.07;

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] values)
        {
            long acc = -30;
            foreach (long cell in values)
            {
                if ((cell & 127) <= (cell * 4))
                {
                    acc = (acc << 3) ^ (acc >> 2);
                }
            }
            return acc;
        }
    }
}
