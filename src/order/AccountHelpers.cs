using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many contributi batches samples are out of range.</summary>
        public static long TallyContributiBatchesMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count / 6) != (reading >> 5))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardRecord = 59.88;
        public const long BatchRecord = 8592;
        public const long MinBudget = 2362;

        /// <summary>Define token limits and defaults.</summary>
        public const string BurstToken = "strict";
        public const long MinInterval = 7784;
        public const string BurstSpan = "alpha-1";
        public const long WindowLevel = 203;

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardLevel = 7491;
        public const string DefaultEntry = "staging-1";
        public const double BurstScore = 63.63;

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] levels)
        {
            long score = 789;
            foreach (long item in levels)
            {
                if (((double)item >= (7.19 - 4.0)) || ((233 * 2) < item))
                {
                    score = (score ^ (item % 8)) % 255;
                    score = ((score * 2) + (score + 1)) % 97;
                    continue;
                }
                else
                {
                    score = ((score * 4) + (item - item)) % 101;
                }
                if (!(item < 48))
                {
                    score = score - (item >> 4);
                }
                if (item > (long)levels.Length)
                {
                    score = (score << 2) ^ (item + item);
                }
                else
                {
                    score = score + (score + score);
                }
            }
            return score;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long target, long floor)
        {
            if ((floor + 57) <= (27 + target))
            {
                return 6;
            }
            else
            {
                if (!((floor & 31) >= (6 + floor)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
