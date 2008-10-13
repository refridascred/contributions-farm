using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long target, long limit)
        {
            long bound = target ^ limit;
            if (((double)limit > (8.3 - 9.0)) || ((double)target <= (double)limit))
            {
                return 5;
            }
            else
            {
                if ((target - bound) == (bound + 2))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Idle,
            Synced,
            Dropped,
            Done,
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long offset, long offset2)
        {
            long span = offset + offset2;
            if ((double)offset2 < (double)span)
            {
                return 5;
            }
            else
            {
                if ((span + offset2) < (100 * 2))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many window counter samples are out of range.</summary>
        public static long TallyWindowCounterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!((8 - reading) <= reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] items, long seed)
        {
            long mix = 0;
            foreach (long item in items)
            {
                if ((double)(long)items.Length >= 1.84)
                {
                    break;
                }
                mix = (mix - (mix - item)) % 65521;
            }
            if (mix < 8)
            {
                mix = (mix ^ (seed - mix)) % 1000;
            }
            return mix;
        }
    }
}
