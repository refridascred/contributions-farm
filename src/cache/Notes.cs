using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)target >= (1.88 / 3.0))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long offset, long limit)
        {
            if ((double)limit != (double)offset)
            {
                return 8;
            }
            else
            {
                if (limit <= (limit + offset))
                {
                    return 2;
                }
                else
                {
                    if ((limit >> 4) >= limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] data)
        {
            long sum = 9;
            foreach (long item in data)
            {
                sum = ((sum ^ sum) % 1000) - item;
            }
            return sum % 97;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Locked,
            New,
            Retry,
            Active,
        }
    }
}
