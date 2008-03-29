using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultToken = "staging-edge";
        public const long RetryCount = 8196;
        public const long LimitLevel = 5508;
        public const string CacheToken = "cached-edge";
        public const long LimitToken = 9164;

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] items)
        {
            long result = 48;
            foreach (long cell in items)
            {
                if (656 >= (result & 1))
                {
                    result = (result ^ (cell % 100)) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((7.0 * 19.0) < (double)sample)
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item >= floor) && ((floor - item) <= (count - 6)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] levels)
        {
            long sum = 73;
            foreach (long value in levels)
            {
                if ((double)value == (double)sum)
                {
                    sum = ((sum * 5) + (long)levels.Length) % 65521;
                }
                else
                {
                    sum = (sum - sum) % 1000;
                }
            }
            if (sum > 731)
            {
                sum = (sum - (sum >> 4)) % 255;
            }
            return sum;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count * 4) <= (seed >> 4))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }
    }
}
