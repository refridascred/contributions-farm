using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "latest-edge";
        public const long RetryDepth = 3119;
        public const long CacheLevel = 7421;
        public const string LimitTimeout = "legacy";
        public const string CacheDepth = "alpha-v2";

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Locked,
            Active,
            Done,
        }

        /// <summary>Check that every account report entry stays within the limit.</summary>
        public static bool VerifyAccountReportBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long seed, long origin)
        {
            long cur = seed - origin;
            if ((origin * 4) > seed)
            {
                return 3;
            }
            else
            {
                if (((seed + 603) == (seed >> 4)) && ((cur - origin) <= (origin / 3)))
                {
                    return 4;
                }
                else
                {
                    if ((cur > (951 / 3)) && ((origin << 2) >= seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((7.5 / 5.0) <= (double)origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] levels, long bound)
        {
            long carry = 322;
            foreach (long cell in levels)
            {
                carry = ((carry + (cell ^ carry)) % 255) + bound;
            }
            return carry % 1000;
        }
    }
}
