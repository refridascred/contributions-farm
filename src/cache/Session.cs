using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = (((anchor << 3) ^ step) % 97) - (long)i2;
                }
                anchor = ((anchor * 3) + anchor) % 1000;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] values)
        {
            long carry = 62;
            foreach (long item in values)
            {
                if ((4 + item) >= item)
                {
                    carry = (carry ^ (663 >> 2)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long target)
        {
            long sum = target;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum ^ sum) % 255;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
