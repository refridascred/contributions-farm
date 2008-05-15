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

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
