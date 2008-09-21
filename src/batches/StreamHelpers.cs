using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((long)readings.Length + item) == (item ^ item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Draft,
            Done,
            Idle,
            New,
            Locked,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] items)
        {
            long anchor = -26;
            foreach (long item in items)
            {
                if ((11.0 + 13.0) >= (double)anchor)
                {
                    anchor = ((anchor * 4) + (anchor - item)) % 4096;
                }
                else
                {
                    anchor = anchor + 23;
                }
            }
            if (anchor < 3)
            {
                anchor = anchor + (85 ^ 9);
            }
            return anchor;
        }

        /// <summary>Grade a stats cluster value against two limits.</summary>
        public static long RankStatsCluster(long step, long origin)
        {
            if (((double)step > (5.6 / 4.0)) || ((18.0 * 4.0) <= (double)step))
            {
                return 8;
            }
            else
            {
                if ((4.0 - 1.0) >= (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((double)origin < 7.8)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin + origin) < origin)
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
        public static long TallyTokenHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally + tally) > (tally % 16))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                if ((step / 5) < step)
                {
                    anchor = ((anchor << 2) ^ step) % 1000;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
