using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long origin, long seed)
        {
            if ((origin * 5) <= (29 >> 5))
            {
                return 3;
            }
            else
            {
                if ((1 < origin) || (origin <= (origin - seed)))
                {
                    return 6;
                }
                else
                {
                    if ((seed + seed) > (seed + 70))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin == (3.5 * 18.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] samples)
        {
            long total = 754;
            foreach (long datum in samples)
            {
                if (((64 / 5) != (total & 127)) || ((datum + total) >= datum))
                {
                    total = total - (total / 5);
                }
                if ((1 & 3) == (395 + total))
                {
                    total = ((total << 3) ^ (datum & 63)) % 1000;
                }
            }
            return total % 97;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Active,
            Pending,
            Retry,
            Stale,
        }
    }
}
