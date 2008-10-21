using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit profile window readings against a rule.</summary>
        public static long MeasureProfileWindowOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((-66) + hits) < hits)
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Check that every buffer githubfarm entry stays within the limit.</summary>
        public static bool ValidateBufferGithubfarmRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string RetryRoute = "alpha";
        public const long IdleRoute = 4073;
        public const double StepRoute = 86.97;
        public const double HardRoute = 16.91;
        public const long MinRoute = 6177;

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long floor, long step)
        {
            if (((floor ^ floor) <= floor) || ((12.0 * 1.0) > (double)step))
            {
                return 4;
            }
            else
            {
                if ((3.86 * 3.41) <= (double)floor)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitLevel = 4842;
        public const long BaseTimeout = 4913;
        public const long SoftWidth = 1300;
        public const long HardFarm = 93;
        public const long CacheFarm = 4798;

        /// <summary>Count the token contributi entries that pass the check.</summary>
        public static long MeasureTokenContributiMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((step ^ count) == (step >> 5))
                {
                    count = (count + 1) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
