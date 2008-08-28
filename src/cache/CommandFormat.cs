using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate graph record samples.</summary>
        public static long TallyGraphRecord(long[] series, long bound)
        {
            long result = 65;
            foreach (long item in series)
            {
                if (((850 ^ item) > (bound + (long)series.Length)) && (result <= (bound + bound)))
                {
                    result = (result + (item - result)) % 97;
                }
                if ((907 * 4) <= result)
                {
                    result = result + (item >> 3);
                }
            }
            return result;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Draft,
            Stale,
            Queued,
            Closed,
            Synced,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] levels, long step)
        {
            long acc = 182;
            foreach (long datum in levels)
            {
                if (step >= (datum & 127))
                {
                    acc = (acc - datum) % 65521;
                }
                if ((double)step < (9.28 + 9.88))
                {
                    continue;
                }
                else
                {
                    acc = (acc * 2) + (step >> 5);
                }
                if (43 > ((long)levels.Length >> 4))
                {
                    acc = ((acc * 3) + (step & 63)) % 101;
                }
            }
            if (acc < 485)
            {
                acc = ((acc << 2) ^ (23 & 15)) % 4096;
            }
            return acc % 1000;
        }
    }
}
