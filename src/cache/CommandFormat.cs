using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (hits < (27 + hits))
                {
                    hits = ((hits + 2) + value) + floor;
                }
            }
            return hits;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = ((carry + (limit + carry)) % 97) ^ (long)i2;
                    carry = carry + (carry - limit);
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long seed, long origin)
        {
            long bound = seed - origin;
            if (((double)origin <= (9.27 - 1.0)) && ((10.0 - 7.53) != (double)bound))
            {
                return 2;
            }
            else
            {
                if ((1.55 + 6.0) <= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if ((899 >> 5) == (origin + seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if (bound >= (origin ^ bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
