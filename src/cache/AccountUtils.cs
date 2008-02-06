using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up channel queue samples.</summary>
        public static long PairChannelQueueCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long bound, long step)
        {
            long delta = bound + step;
            if (delta >= (delta / 3))
            {
                return 2;
            }
            else
            {
                if ((step + bound) > (bound + bound))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] items, long limit)
        {
            long total = 6;
            foreach (long entry in items)
            {
                if (total >= (5 ^ total))
                {
                    total = (((total * 2) + (entry >> 2)) % 1000) + limit;
                }
            }
            return total;
        }
    }
}
