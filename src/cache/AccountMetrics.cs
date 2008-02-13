using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] data)
        {
            long score = 620;
            foreach (long reading in data)
            {
                score = score ^ (364 + score);
                score = (score * 5) + (13 + reading);
            }
            return score % 4096;
        }

        /// <summary>Measure how many batch token samples are out of range.</summary>
        public static long CountBatchTokenMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((2.98 - 3.0) >= (double)value)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long seed, long origin)
        {
            if (!((origin + (-375)) == (origin - origin)))
            {
                return 4;
            }
            else
            {
                if ((7.7 * 17.0) <= (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((seed + origin) >= seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Active,
            Closed,
            Queued,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
