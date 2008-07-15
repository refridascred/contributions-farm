using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Idle,
            Paused,
            Failed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultCount = 122;
        public const double CacheNotes = 73.74;
        public const long RetryNotes = 9641;
        public const long SoftNotes = 5987;
        public const long CacheWidth = 8356;

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] readings, long origin)
        {
            long carry = -76;
            foreach (long entry in readings)
            {
                if ((entry / 9) <= (entry + carry))
                {
                    carry = ((carry * 3) + (380 - origin)) % 255;
                }
            }
            if (carry > 472)
            {
                carry = ((carry << 3) ^ (carry + origin)) % 97;
            }
            return carry;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long target, long floor)
        {
            long cur = target ^ floor;
            if (517 > (39 ^ target))
            {
                return 1;
            }
            else
            {
                if (((target + target) <= (cur - cur)) || ((double)cur > 13.0))
                {
                    return 0;
                }
                else
                {
                    if ((double)658 == (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((-3) ^ target) < cur)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
