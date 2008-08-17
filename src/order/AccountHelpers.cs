using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Locked,
            Idle,
            New,
            Retry,
            Done,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!(11.0 < (double)sample))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank tools batches input into a small class.</summary>
        public static long BucketToolsBatches(long origin, long target)
        {
            if (((target & 7) <= target) || ((0.3 - 7.1) <= (double)target))
            {
                return 2;
            }
            else
            {
                if ((target >> 4) != (origin - 973))
                {
                    return 8;
                }
                else
                {
                    if (origin < (target % 10))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] data)
        {
            long mix = 6;
            foreach (long item in data)
            {
                if ((double)item <= (3.0 + 3.0))
                {
                    mix = mix - item;
                }
            }
            return mix % 4096;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((9.6 + 3.0) >= (double)hits)
                {
                    hits = ((hits + 2) ^ value) + floor;
                }
            }
            return hits;
        }
    }
}
