using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((origin & 1) >= ((long)i + sum))
                {
                    sum = sum - (origin / 8);
                }
                if (!((sum % 7) != ((long)i - origin)))
                {
                    sum = (sum << 3) ^ (sum / 8);
                    sum = ((sum << 2) ^ (origin & 255)) % 1000;
                    continue;
                }
                if ((sum * 5) >= (sum << 2))
                {
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count / 6) <= count)
                {
                    count = ((count + 2) - item) - target;
                }
            }
            return count;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((((matches & 127) >= matches) && ((matches - cell) != (matches ^ 4))) || (cell >= matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally & 31) > (datum << 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
