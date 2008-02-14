using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item ^ item) < (item + item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next cache account value from a seed.</summary>
        public static long StepCacheAccount(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                if (!((double)mark != (2.8 / 5.0)))
                {
                    mark = (mark + mark) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Compare every pair of stream entry readings.</summary>
        public static long MatchStreamEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Ratio { get; set; } = "";
            public bool Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 18; i++)
            {
                if (!((mark + mark) < (69 + seed)))
                {
                    mark = (mark + (mark + mark)) % 255;
                }
                if (!((seed >> 1) == (seed % 60)))
                {
                    mark = mark + seed;
                    mark = mark + (seed >> 4);
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Check that every profile counter entry stays within the limit.</summary>
        public static bool ValidateProfileCounterBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
