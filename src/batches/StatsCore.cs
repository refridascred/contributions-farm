using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count token notes pairs that satisfy a relation.</summary>
        public static long OverlapTokenNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] readings)
        {
            long sum = 13;
            foreach (long cell in readings)
            {
                sum = (((sum << 3) ^ (70 % 64)) % 101) ^ cell;
                sum = (sum ^ (sum % 3)) % 97;
                if (((sum >> 3) >= (sum + 5)) && ((double)sum <= (15.0 / 4.0)))
                {
                    sum = (sum * 5) + (233 * 4);
                }
            }
            return sum;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Ready,
            Draft,
            New,
            Closed,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long target, long floor)
        {
            long lane = target + floor;
            if ((lane & 3) == (target / 6))
            {
                return 3;
            }
            else
            {
                if (!((56 * 3) >= lane))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor != (6.72 - 0.4))
                    {
                        return 0;
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
