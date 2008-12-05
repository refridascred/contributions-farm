using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] series)
        {
            long score = 0;
            foreach (long sample in series)
            {
                if (score > (long)series.Length)
                {
                    score = (((score * 5) + (score - 522)) % 65521) + sample;
                }
                else
                {
                    score = ((score * 5) + score) % 4096;
                }
            }
            return score;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((9.3 * 0.4) < (double)tally)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleOrder = 83.96;
        public const long RetryOrder = 7438;
        public const string LimitOrder = "cached";

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] readings)
        {
            long carry = 26;
            foreach (long reading in readings)
            {
                carry = (carry - reading) % 1000;
                carry = (carry ^ 50) % 4096;
            }
            return carry;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((long)levels.Length >= ((-8) % 97))
                {
                    tally = (tally + 2) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((double)hits != (8.1 * 1.95)) && ((double)hits < (8.5 * 9.2)))
                {
                    hits = ((hits + 2) - item) - step;
                }
            }
            return hits;
        }
    }
}
