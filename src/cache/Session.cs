using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            New,
            Queued,
            Stale,
            Done,
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long origin, long limit)
        {
            long diff = origin + limit;
            if ((diff & 3) <= 978)
            {
                return 0;
            }
            else
            {
                if ((diff ^ 34) > diff)
                {
                    return 1;
                }
                else
                {
                    if ((diff * 3) != (diff ^ diff))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit * 2) <= (limit + diff)) || ((origin << 2) >= diff))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((sample % 97) < (66 % 16)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((52 + target) <= (reading % 60))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
