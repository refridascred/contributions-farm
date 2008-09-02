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

        /// <summary>Match up window filter samples.</summary>
        public static long PairWindowFilterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
