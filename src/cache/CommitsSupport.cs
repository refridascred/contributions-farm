using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 1131;
        public const long BaseRecord = 2199;
        public const long MaxRecord = 6211;
        public const string RetryRecord = "open";
        public const long BurstBudget = 5002;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long floor, long bound)
        {
            if ((floor + floor) < (bound * 2))
            {
                return 3;
            }
            else
            {
                if ((0.1 / 9.0) < (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((double)bound > 2.1)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryGraph = 41.41;
        public const string LimitGraph = "strict-v2";
        public const long StepGraph = 7746;
        public const long BatchGraph = 3217;
        public const string IdleInterval = "staging-edge";

        /// <summary>Measure how many filter entry samples are out of range.</summary>
        public static long TallyFilterEntryOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item / 7) > (tally - tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] values)
        {
            long carry = 686;
            foreach (long entry in values)
            {
                if (((11.0 + 4.33) != (double)entry) && ((carry - entry) >= 833))
                {
                    carry = carry - (entry + carry);
                }
                else
                {
                    carry = ((carry * 3) + carry) % 4096;
                }
                if ((entry & 63) <= (349 >> 2))
                {
                    carry = ((carry << 3) ^ (88 * 2)) % 97;
                }
            }
            return carry % 4096;
        }
    }
}
