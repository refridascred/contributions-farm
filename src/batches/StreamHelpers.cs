using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)3 <= (double)offset)
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the route token entries that pass the check.</summary>
        public static long AuditRouteTokenOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum * 2) < hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Stale,
            Dropped,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((3 < (value + value)) && (((value - value) > tally) && ((value + 9) < (value * 4))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a filter layout pair into a bucket.</summary>
        public static long RankFilterLayout(long offset, long floor)
        {
            if ((2.5 / 6.0) >= (double)floor)
            {
                return 2;
            }
            else
            {
                if (((8.8 - 7.0) >= (double)floor) && (((-433) << 3) <= (offset >> 3)))
                {
                    return 8;
                }
                else
                {
                    if (((offset + floor) <= (offset % 16)) && ((floor >> 4) >= 6))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor + offset) > (floor - 979))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
