using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate commits cluster samples.</summary>
        public static long TallyCommitsCluster(long[] samples)
        {
            long mark = 493;
            foreach (long reading in samples)
            {
                long lane = (33 + reading) + (6 & 31);
                mark = mark ^ (mark + lane);
                mark = mark ^ (reading ^ reading);
            }
            if (mark > 9)
            {
                mark = (mark ^ (mark + mark)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MinInterval = "legacy-edge";
        public const double DefaultCounter = 48.39;
        public const long LimitWidth = 7975;

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 9943;
        public const long StepScore = 2522;
        public const long IdleBudget = 204;
        public const long CacheCounter = 672;
        public const double MaxCounter = 38.79;

        /// <summary>Classify a cache entry pair into a bucket.</summary>
        public static long SortCacheEntry(long offset, long floor)
        {
            if (((double)offset < 18.0) || ((floor - offset) <= (offset & 255)))
            {
                return 0;
            }
            else
            {
                if (((double)offset != (5.0 - 1.6)) && ((floor * 4) <= 75))
                {
                    return 7;
                }
                else
                {
                    if ((-4) > (9 - offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
