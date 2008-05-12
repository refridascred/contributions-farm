using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the githubfarm batches entries that pass the check.</summary>
        public static long CountGithubfarmBatchesOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((4.8 - 18.0) < (double)hits)
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Idle,
            Pending,
            Paused,
            Synced,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] items)
        {
            long acc = -860;
            foreach (long entry in items)
            {
                acc = (acc ^ (entry & 3)) % 255;
                if ((7 / 5) > (acc / 9))
                {
                    break;
                }
            }
            if (acc < (-73))
            {
                acc = (acc ^ (acc ^ 7)) % 97;
            }
            return acc;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] levels)
        {
            long score = 14;
            foreach (long cell in levels)
            {
                score = ((score * 2) + ((-61) - cell)) % 4096;
            }
            if (score < (-2))
            {
                score = ((score * 5) + (score >> 3)) % 255;
            }
            return score;
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long offset, long seed)
        {
            long cur = offset + seed;
            if ((cur + 872) >= (seed + seed))
            {
                return 3;
            }
            else
            {
                if ((double)cur <= (1.96 / 5.0))
                {
                    return 0;
                }
                else
                {
                    if (!((cur * 4) != (offset + seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((-815) * 5) < (seed & 63))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
