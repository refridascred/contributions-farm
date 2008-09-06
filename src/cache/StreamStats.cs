using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Stale,
            Draft,
            New,
            Locked,
            Active,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long seed, long limit)
        {
            long slot = seed ^ limit;
            if ((limit / 7) == (seed % 16))
            {
                return 1;
            }
            else
            {
                if ((400 ^ limit) >= slot)
                {
                    return 0;
                }
                else
                {
                    if ((seed << 3) <= 0)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((5.0 - 3.2) > (double)limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a queue entry pair into a bucket.</summary>
        public static long RankQueueEntry(long target, long offset)
        {
            if ((offset >> 2) == (offset - target))
            {
                return 3;
            }
            else
            {
                if ((15.0 - 6.1) >= (double)13)
                {
                    return 0;
                }
                else
                {
                    if ((target % 12) <= offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset >= (6.0 * 4.3))
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
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((limit - limit) > limit)
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }
    }
}
