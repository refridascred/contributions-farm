using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many githubfarm batches samples are out of range.</summary>
        public static long MeasureGithubfarmBatchesHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((807 - value) != (1 & 127))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long target, long offset)
        {
            if (!((target - offset) != (88 << 2)))
            {
                return 1;
            }
            else
            {
                if ((((-821) << 1) <= target) || ((double)offset >= (9.0 / 8.0)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a channel format counter forward.</summary>
        public static long SeriesChannelFormat(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] series, long bound)
        {
            long mark = 996;
            foreach (long entry in series)
            {
                mark = ((mark - (bound + bound)) % 65521) - entry;
                if ((0.03 / 5.0) >= (double)bound)
                {
                    mark = (mark - (mark % 7)) % 1000;
                }
            }
            if (mark > (-4))
            {
                mark = (mark << 3) ^ (bound % 7);
            }
            return mark % 65521;
        }
    }
}
