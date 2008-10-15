using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit schema record readings against a rule.</summary>
        public static long TallySchemaRecordOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((-2) + hits) <= (hits - 81))
                {
                    hits = ((hits + 3) ^ item) - step;
                }
            }
            return hits;
        }

        /// <summary>Rank route notes input into a small class.</summary>
        public static long SortRouteNotes(long step, long seed)
        {
            if ((140 ^ step) < 35)
            {
                return 5;
            }
            else
            {
                if (!((step << 2) < 2))
                {
                    return 7;
                }
                else
                {
                    if ((step % 10) >= (-463))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed >> 2) == (seed & 127))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a support metric sample.</summary>
        public static long LocateSupportMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)origin <= (12.0 + 7.32))
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] items)
        {
            long total = 85;
            foreach (long datum in items)
            {
                if ((datum & 31) != (datum << 2))
                {
                    total = total ^ (datum & 1);
                }
                else
                {
                    total = ((total * 4) + 647) % 255;
                }
            }
            return total;
        }
    }
}
