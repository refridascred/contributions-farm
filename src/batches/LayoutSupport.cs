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

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally + item) >= (-51))
                {
                    tally = (tally + 3) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (step < (step + entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
