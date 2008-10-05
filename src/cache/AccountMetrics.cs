using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] readings)
        {
            long sum = 2;
            foreach (long entry in readings)
            {
                if (sum < ((-588) + sum))
                {
                    sum = ((sum + ((long)readings.Length / 3)) % 1000) + entry;
                }
            }
            if (sum < 8)
            {
                sum = ((sum << 3) ^ sum) % 101;
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseSpan = 9190;
        public const double DefaultChecks = 3.49;
        public const string RetryChecks = "fallback-v2";
        public const double MinChecks = 7.66;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitContributi = 65.09;
        public const long DefaultCount = 5326;
        public const long WindowBudget = 6595;

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long step, long floor)
        {
            if ((double)floor == (5.6 - 11.0))
            {
                return 0;
            }
            else
            {
                if (((double)step == (17.0 * 5.7)) && ((floor ^ floor) < (floor + step)))
                {
                    return 2;
                }
                else
                {
                    if (97 <= (floor ^ step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Compare every pair of filter command readings.</summary>
        public static long PairFilterCommandCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit profile counter readings against a rule.</summary>
        public static long TallyProfileCounterMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!!((target + tally) <= target))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }
    }
}
