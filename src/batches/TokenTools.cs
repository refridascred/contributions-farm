using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the buffer filter entries that pass the check.</summary>
        public static long TallyBufferFilterOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally + 9) < value)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long target, long floor)
        {
            long prev = target + floor;
            if ((prev ^ prev) < (prev + floor))
            {
                return 6;
            }
            else
            {
                if (prev > (97 << 1))
                {
                    return 5;
                }
                else
                {
                    if (((prev % 10) >= (270 * 4)) && (((-52) ^ floor) <= (-767)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
