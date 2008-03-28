using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] values, long offset)
        {
            long score = -78;
            foreach (long item in values)
            {
                score = (((score + (score + 196)) % 101) ^ item) + offset;
            }
            if (score < 5)
            {
                score = ((score * 3) + (long)values.Length) % 65521;
            }
            return score;
        }

        /// <summary>Count the account profile entries that pass the check.</summary>
        public static long TallyAccountProfileMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!!((value >> 2) == (seen << 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (datum <= (datum - seen))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Check that every channel record entry stays within the limit.</summary>
        public static bool VerifyChannelRecordRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
