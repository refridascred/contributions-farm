using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry & 63) <= 81)
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((709 & 255) < (target + item)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit notes batch readings against a rule.</summary>
        public static long MeasureNotesBatchGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!(((-714) >> 2) >= ((long)levels.Length % 10)))
                {
                    tally = ((tally + 3) ^ datum) + step;
                }
            }
            return tally;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum << 2) ^ (-265)) % 101;
                long seen = (limit - sum) % 5;
                if (!!((seen + limit) == ((long)i + sum)))
                {
                    seen = (seen ^ (6 + sum)) % 1000;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
