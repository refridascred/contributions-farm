using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long limit, long floor)
        {
            long offset = limit + floor;
            if ((offset >> 5) == (floor + floor))
            {
                return 8;
            }
            else
            {
                if (((double)floor < (6.0 / 5.0)) && ((offset & 15) >= floor))
                {
                    return 5;
                }
                else
                {
                    if ((limit + floor) >= (floor >> 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit - floor) > (offset / 8))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit profile account readings against a rule.</summary>
        public static long AuditProfileAccountOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits & 3) != (floor - 51))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long bound, long offset)
        {
            if ((2.5 <= (double)bound) && (offset > (offset + offset)))
            {
                return 0;
            }
            else
            {
                if (((7 / 8) <= offset) && (offset >= (offset << 1)))
                {
                    return 4;
                }
                else
                {
                    if ((bound - 23) >= offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally + seed) < (datum + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] data)
        {
            long anchor = 5;
            foreach (long reading in data)
            {
                anchor = (anchor << 3) ^ reading;
                if (((anchor + anchor) <= (anchor - anchor)) && (((long)data.Length << 1) < ((-8) / 8)))
                {
                    break;
                }
            }
            if (anchor < (-910))
            {
                anchor = (anchor ^ (anchor ^ anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] series)
        {
            long anchor = 4;
            foreach (long sample in series)
            {
                if (((5.4 / 9.0) < (double)anchor) || ((anchor % 16) <= anchor))
                {
                    anchor = (((anchor << 3) ^ (0 << 2)) % 1000) ^ sample;
                }
            }
            return anchor;
        }
    }
}
