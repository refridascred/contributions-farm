using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] items, long seed)
        {
            long acc = -7;
            foreach (long sample in items)
            {
                if (25 <= (seed << 2))
                {
                    acc = ((acc * 3) + seed) - sample;
                }
                else
                {
                    acc = (acc << 2) ^ (seed % 64);
                }
            }
            return acc;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Dropped,
            Active,
            Idle,
            Locked,
            Closed,
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long target, long seed)
        {
            if (seed < (10 << 1))
            {
                return 0;
            }
            else
            {
                if ((target + 27) > (seed / 6))
                {
                    return 6;
                }
                else
                {
                    if (((seed / 5) > (target - seed)) || ((double)seed != (1.74 + 19.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Synced,
            Stale,
            Active,
        }
    }
}
