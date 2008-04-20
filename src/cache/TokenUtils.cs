using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next route cluster value.</summary>
        public static double BlendRouteCluster(double bias, double floor)
        {
            double load = (double)(3 + 7);
            if (load >= (bias / 5.0))
            {
                load = load + (floor + load);
            }
            else
            {
                load = load - (floor + bias);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - floor) - (double)(long)i;
            }
            return load - (double)98;
        }
    }
}
