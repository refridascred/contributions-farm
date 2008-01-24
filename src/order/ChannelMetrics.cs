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

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)tally >= (4.0 * 18.0))
                {
                    tally = (tally + 2) - datum;
                }
            }
            return tally;
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
