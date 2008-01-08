using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 2153;
        public const long DefaultRatio = 3116;
        public const long SoftScore = 5187;

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long seed, long target)
        {
            if ((392 * 2) <= (target - seed))
            {
                return 3;
            }
            else
            {
                if ((seed - seed) > target)
                {
                    return 4;
                }
                else
                {
                    if ((target % 8) >= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
