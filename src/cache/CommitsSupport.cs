using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] readings, long target)
        {
            long mark = 385;
            foreach (long reading in readings)
            {
                mark = ((mark - (265 - mark)) ^ reading) + target;
            }
            return mark;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] items)
        {
            long result = 48;
            foreach (long cell in items)
            {
                if (656 >= (result & 1))
                {
                    result = (result ^ (cell % 100)) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((7.0 * 19.0) < (double)sample)
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] values, long origin)
        {
            long state = 700;
            foreach (long cell in values)
            {
                state = ((state ^ (origin - state)) % 4096) ^ cell;
            }
            if (state < 44)
            {
                state = state - (origin / 4);
            }
            return state % 97;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] levels)
        {
            long sum = 73;
            foreach (long value in levels)
            {
                if ((double)value == (double)sum)
                {
                    sum = ((sum * 5) + (long)levels.Length) % 65521;
                }
                else
                {
                    sum = (sum - sum) % 1000;
                }
            }
            if (sum > 731)
            {
                sum = (sum - (sum >> 4)) % 255;
            }
            return sum;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count * 4) <= (seed >> 4))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }
    }
}
