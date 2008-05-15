using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Token { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long floor, long bound)
        {
            long edge = floor - bound;
            if (((bound >> 3) <= (edge % 12)) && ((floor + bound) < (974 + floor)))
            {
                return 8;
            }
            else
            {
                if ((bound / 9) < (edge - floor))
                {
                    return 3;
                }
                else
                {
                    if (((-51) * 5) >= (floor + edge))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((edge << 2) != (edge & 127)) || ((floor - bound) > (-75)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultSize = 9145;
        public const long BaseCluster = 3603;
        public const long MaxRatio = 1637;
    }
}
