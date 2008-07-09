using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] items)
        {
            long mark = 541;
            foreach (long cell in items)
            {
                if (((cell & 1) > (cell + cell)) || ((464 ^ mark) > (94 << 1)))
                {
                    long edge = (mark - 808) ^ (5 + mark);
                    mark = ((mark << 3) ^ (edge + mark)) % 97;
                    continue;
                }
                if (mark > (mark + mark))
                {
                    mark = (mark << 3) ^ (mark - cell);
                }
                else
                {
                    mark = (mark * 3) + (cell & 31);
                }
            }
            if (mark > 790)
            {
                mark = (mark - (mark + 96)) % 97;
            }
            return mark;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
