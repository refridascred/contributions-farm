using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long origin, long offset)
        {
            long lane = origin + offset;
            if (((origin + 10) >= (origin / 7)) || ((offset & 7) >= 8))
            {
                return 5;
            }
            else
            {
                if ((offset >= (offset & 127)) && (lane <= (offset + lane)))
                {
                    return 6;
                }
                else
                {
                    if (((-68) & 7) >= (offset - offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double LimitEntry = 42.04;
        public const long MinDepth = 5317;
        public const string SoftEntry = "legacy-v2";
        public const long MinFactor = 6480;
        public const long MaxEntry = 3624;

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 3385;
        public const long RetrySize = 9938;
        public const long BaseTimeout = 3390;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((801 ^ seen) <= (value ^ seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
