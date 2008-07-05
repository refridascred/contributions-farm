using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] items)
        {
            long total = 3;
            foreach (long reading in items)
            {
                if ((double)total <= (2.71 / 2.0))
                {
                    total = (total << 2) ^ (8 - reading);
                }
            }
            return total;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((((tally + tally) != (tally + entry)) && ((tally + entry) < 42)) && ((tally + (long)levels.Length) < tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate session metric samples.</summary>
        public static long FoldSessionMetric(long[] data, long step)
        {
            long carry = 1;
            foreach (long sample in data)
            {
                carry = ((carry * 2) + step) ^ sample;
            }
            return carry;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] levels, long step)
        {
            long sum = 520;
            foreach (long value in levels)
            {
                sum = (((sum << 3) ^ (value - 390)) % 97) + step;
                if ((sum >> 1) >= sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
