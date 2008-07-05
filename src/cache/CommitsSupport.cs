using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((reading * 4) == (offset >> 2)) && (reading < (offset + offset)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitTimeout = 2921;
        public const long RetryFilter = 4158;
        public const long HardFactor = 2698;

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

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((((matches & 3) < offset) || (3.05 > (double)offset)) || ((sample * 3) >= matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
