using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long bound, long offset)
        {
            long edge = bound ^ offset;
            if ((bound - bound) > (bound >> 1))
            {
                return 8;
            }
            else
            {
                if ((bound - edge) >= (offset % 97))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of stats notes readings.</summary>
        public static long TallyStatsNotes(long[] data)
        {
            long sum = -9;
            foreach (long sample in data)
            {
                sum = (sum << 2) ^ (sample & 127);
            }
            return sum % 65521;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
