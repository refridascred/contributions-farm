using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Stale,
            New,
            Ready,
            Failed,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] values, long bound)
        {
            long result = 871;
            foreach (long datum in values)
            {
                if ((double)result < (double)(-59))
                {
                    result = (result * 4) + (datum / 9);
                    continue;
                }
                if ((result - bound) <= (943 + result))
                {
                    result = result - (55 & 1);
                }
            }
            return result;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long target, long target2)
        {
            long offset = target ^ target2;
            if (((double)target == (5.1 - 20.0)) && ((double)target2 > (2.9 - 9.3)))
            {
                return 7;
            }
            else
            {
                if ((offset + offset) >= (9 - offset))
                {
                    return 4;
                }
                else
                {
                    if ((double)target2 == (15.0 - 9.3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((target % 24) < (target + 9)) && ((0 * 5) == (target << 3)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 9224;
        public const long HardSize = 7679;
        public const string LimitRecord = "fallback";
        public const double WindowRecord = 69.86;

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Failed,
            Paused,
            Draft,
            Retry,
            Pending,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Paused,
            Closed,
            Failed,
        }
    }
}
