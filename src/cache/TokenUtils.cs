using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long seed, long origin)
        {
            long cur = seed + origin;
            if (!((origin + seed) < seed))
            {
                return 8;
            }
            else
            {
                if (!((168 ^ origin) >= cur))
                {
                    return 5;
                }
                else
                {
                    if ((cur <= (cur - cur)) && ((17.0 * 17.0) > (double)origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Look up the position of a payload filter sample.</summary>
        public static long LookupPayloadFilterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of tools session readings.</summary>
        public static long OverlapToolsSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
