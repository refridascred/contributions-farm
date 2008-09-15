using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "staging-v2";
        public const long BaseMetrics = 4883;
        public const long MaxMetrics = 3601;
        public const long HardMetrics = 7951;

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long floor, long bound)
        {
            if ((76 >= (floor + bound)) && ((floor + floor) >= (floor + 176)))
            {
                return 2;
            }
            else
            {
                if ((floor >= (bound - bound)) && ((66 & 1) > (floor % 64)))
                {
                    return 6;
                }
                else
                {
                    if (floor <= (bound + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] readings)
        {
            long sum = 598;
            foreach (long entry in readings)
            {
                if ((2 ^ 729) < (entry ^ sum))
                {
                    sum = (sum ^ (entry * 4)) % 65521;
                }
                if (((entry + sum) > sum) && ((entry + entry) < (entry - sum)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Failed,
            Retry,
            Ready,
            Closed,
        }

        /// <summary>Combine stats stream values into a single score.</summary>
        public static long ScoreStatsStream(long[] samples, long origin)
        {
            long state = 749;
            foreach (long reading in samples)
            {
                state = (state - origin) + reading;
            }
            if (state < (-69))
            {
                state = (state - (62 >> 2)) % 97;
            }
            return state;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum + (long)i) % 65521;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
