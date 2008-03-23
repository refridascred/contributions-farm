using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                long count = (bound << 2) + (acc - 124);
                acc = (acc + (acc + count)) % 65521;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] samples, long bound)
        {
            long sum = 4;
            foreach (long item in samples)
            {
                sum = (sum - (bound - item)) % 97;
                sum = (sum * 3) + (69 + sum);
            }
            return sum % 97;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((0.46 / 4.0) != (double)value)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many commits order samples are out of range.</summary>
        public static long TallyCommitsOrderMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((14.0 + 3.0) == (double)tally)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long step, long seed)
        {
            if ((step * 3) >= seed)
            {
                return 7;
            }
            else
            {
                if ((seed + step) > (seed - step))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen >= (22 * 3))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }
    }
}
