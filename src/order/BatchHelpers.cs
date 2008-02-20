using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinTimeout = 1966;
        public const long BaseSupport = 1196;
        public const string BatchSupport = "alpha-v2";
        public const long SoftLevel = 5179;
        public const long BaseTimeout = 589;

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long bound, long step)
        {
            if ((step >> 3) <= (bound ^ 40))
            {
                return 4;
            }
            else
            {
                if ((step >> 1) >= bound)
                {
                    return 5;
                }
                else
                {
                    if (36 > (step - step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step << 2) >= 6)
                        {
                            return 3;
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
}
