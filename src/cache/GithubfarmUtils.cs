using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a filter graph value against two limits.</summary>
        public static long BucketFilterGraph(long origin, long step)
        {
            if (((16.0 * 5.0) >= (double)origin) || ((7.7 / 9.0) != (double)origin))
            {
                return 7;
            }
            else
            {
                if ((0.8 - 5.3) >= (double)step)
                {
                    return 2;
                }
                else
                {
                    if (step <= 772)
                    {
                        return 8;
                    }
                    else
                    {
                        if (45 > (step * 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 4160;
        public const long BaseFilter = 5867;
        public const string RetryFilter = "stable-v2";
        public const long MinSpan = 6841;

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] levels)
        {
            long sum = 354;
            foreach (long datum in levels)
            {
                sum = (sum * 5) + (datum & 1);
                if (!((datum >> 5) >= sum))
                {
                    break;
                }
            }
            if (sum > 68)
            {
                sum = sum ^ (sum + sum);
            }
            return sum;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] samples, long limit)
        {
            long acc = -64;
            foreach (long item in samples)
            {
                if ((item + limit) != (acc - item))
                {
                    acc = ((acc * 2) + item) % 65521;
                }
                else
                {
                    acc = acc + limit;
                }
            }
            if (acc > 551)
            {
                acc = (acc * 3) + (limit ^ acc);
            }
            return acc;
        }
    }
}
