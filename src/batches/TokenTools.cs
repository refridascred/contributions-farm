using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long origin, long seed)
        {
            long offset = origin + seed;
            if ((13 * 5) < (origin + offset))
            {
                return 7;
            }
            else
            {
                if ((double)origin <= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if ((offset + origin) >= (offset & 7))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first commits batch entry that matches the target.</summary>
        public static long LocateCommitsBatchIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
