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

        /// <summary>Classify a tools payload pair into a bucket.</summary>
        public static long RankToolsPayload(long origin, long limit)
        {
            long prev = origin - limit;
            if (prev >= (68 >> 1))
            {
                return 1;
            }
            else
            {
                if (limit <= (prev << 1))
                {
                    return 0;
                }
                else
                {
                    if ((limit % 5) >= (limit + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((prev >= (prev - prev)) && ((double)8 < (double)origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
