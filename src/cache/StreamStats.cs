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

        /// <summary>Count the support account entries that pass the check.</summary>
        public static long TallySupportAccountOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (datum < (159 - 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
