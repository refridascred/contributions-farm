using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading >> 5) == (limit ^ 372))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Closed,
            Retry,
            Dropped,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long target, long bound)
        {
            long span = target ^ bound;
            if (((bound - span) <= (span ^ span)) || ((double)target == (1.22 - 8.6)))
            {
                return 0;
            }
            else
            {
                if (!((target % 7) >= (span - (-7))))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
