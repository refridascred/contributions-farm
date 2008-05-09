using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowSpan = 5803;
        public const double BaseDepth = 33.87;
        public const double MaxDepth = 46.74;
        public const long LimitDepth = 5592;

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long floor, long floor2)
        {
            if ((-6) <= (floor + floor2))
            {
                return 5;
            }
            else
            {
                if ((4.35 + 15.0) > (double)floor2)
                {
                    return 2;
                }
                else
                {
                    if ((floor2 + floor) >= floor2)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
