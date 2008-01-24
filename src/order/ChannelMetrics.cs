using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] samples, long seed)
        {
            long sum = 35;
            foreach (long reading in samples)
            {
                if (!((reading - seed) <= sum))
                {
                    sum = sum ^ (seed << 3);
                }
                else
                {
                    sum = (sum * 3) + sum;
                }
                if (((reading % 10) == (sum << 2)) || ((reading >> 5) < 346))
                {
                    break;
                }
            }
            if (sum < 164)
            {
                sum = sum + seed;
            }
            return sum;
        }

        /// <summary>Measure how many tools stats samples are out of range.</summary>
        public static long CountToolsStatsMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (sample >= (sample * 4))
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

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
