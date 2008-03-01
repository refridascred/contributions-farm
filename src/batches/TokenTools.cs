using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of contributi tools readings.</summary>
        public static long ScoreContributiTools(long[] data)
        {
            long result = 4;
            foreach (long item in data)
            {
                if ((item - result) == (98 - result))
                {
                    result = (result << 2) ^ (result * 4);
                }
            }
            return result % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string HardCluster = "fallback-1";
        public const string LimitFactor = "cached-edge";
        public const long DefaultCluster = 8560;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long origin, long floor)
        {
            long step = origin ^ floor;
            if (!((origin + 2) != (77 >> 4)))
            {
                return 5;
            }
            else
            {
                if ((floor + step) < (step << 1))
                {
                    return 6;
                }
                else
                {
                    if ((origin << 1) <= (99 + step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
