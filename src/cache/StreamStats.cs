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

        /// <summary>Audit schema account readings against a rule.</summary>
        public static long TallySchemaAccountGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((9.3 + 6.7) != (double)count)
                {
                    count = ((count + 2) - reading) - offset;
                }
            }
            return count;
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
