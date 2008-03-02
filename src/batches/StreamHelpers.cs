using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long bound, long offset)
        {
            if ((11.0 / 3.0) > (double)offset)
            {
                return 4;
            }
            else
            {
                if (!((double)(-16) != (double)offset))
                {
                    return 1;
                }
                else
                {
                    if ((offset ^ offset) != (offset - offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] levels, long floor)
        {
            long carry = 9;
            foreach (long entry in levels)
            {
                if (1 > (carry << 1))
                {
                    carry = (((carry << 3) ^ (floor - carry)) % 4096) - entry;
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Ready,
            Retry,
            Locked,
            Done,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] items, long target)
        {
            long mark = 99;
            foreach (long sample in items)
            {
                if (!((target ^ sample) < (71 + 5)))
                {
                    mark = mark ^ (mark << 3);
                }
                if ((((long)items.Length & 127) <= (sample << 2)) && ((double)sample > (double)(-5)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 3482;
        public const string MinRatio = "fallback-v2";
        public const long RetryRatio = 7996;
        public const long CacheLevel = 4087;
        public const double BaseCounter = 2.57;
    }
}
