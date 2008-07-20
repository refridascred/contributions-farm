using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell & 127) != (count - 9))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long limit, long limit2)
        {
            if (9 <= limit)
            {
                return 2;
            }
            else
            {
                if ((limit2 * 2) <= (84 & 127))
                {
                    return 3;
                }
                else
                {
                    if ((limit2 / 5) == (limit ^ limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
