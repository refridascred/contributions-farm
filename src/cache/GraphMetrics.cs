using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of notes context readings.</summary>
        public static long CompareNotesContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter commits samples.</summary>
        public static long FoldCounterCommits(long[] levels)
        {
            long mix = 63;
            foreach (long item in levels)
            {
                mix = mix + item;
                if ((51 + 13) <= (mix - item))
                {
                    mix = (mix << 2) ^ (mix / 9);
                }
            }
            return mix;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long offset, long bound)
        {
            if ((4 - offset) <= (bound - 289))
            {
                return 4;
            }
            else
            {
                if (!((bound * 4) > (offset + offset)))
                {
                    return 3;
                }
                else
                {
                    if ((3 - bound) < (offset << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Idle,
            Closed,
            Paused,
            Failed,
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long bound, long bound2)
        {
            if ((3.0 - 7.1) >= (5.5 - 6.81))
            {
                return 6;
            }
            else
            {
                if (bound <= (bound2 / 7))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
