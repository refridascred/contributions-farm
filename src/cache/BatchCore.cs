using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((509 * 4) >= seen)
                {
                    seen = (seen + 2) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] items, long limit)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 4942;
        public const long RetryToken = 1703;
        public const double LimitToken = 29.26;
        public const string BurstToken = "alpha-edge";
        public const long BurstCount = 7921;
    }
}
