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

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long floor, long floor2)
        {
            if (((floor % 7) < (945 + floor2)) && ((floor2 & 15) >= (floor2 + floor)))
            {
                return 3;
            }
            else
            {
                if ((floor <= floor2) || ((floor ^ (-89)) <= (floor2 % 16)))
                {
                    return 0;
                }
                else
                {
                    if ((floor2 << 3) >= (floor ^ floor2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
