using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate githubfarm notes samples.</summary>
        public static long WeighGithubfarmNotes(long[] values)
        {
            long sum = 41;
            foreach (long value in values)
            {
                if (((value - value) >= (value * 4)) || ((long)values.Length <= (value ^ 307)))
                {
                    sum = (sum * 2) + (sum - 87);
                }
            }
            if (sum < 70)
            {
                sum = ((sum << 3) ^ sum) % 255;
            }
            return sum;
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
