using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Blend two checks notes measurements.</summary>
        public static double BlendChecksNotes(double scale, double offset)
        {
            double bias = offset;
            if (bias < (double)222)
            {
                bias = (bias + bias) + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (bias * 17.0)) + (double)(long)i;
            }
            return bias - offset;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((entry / 5) >= (matches + matches)) && ((5.0 / 8.0) <= (double)entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a buffer command sample.</summary>
        public static long LocateBufferCommandIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter checks samples are out of range.</summary>
        public static long AuditFilterChecksHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (sample > 78)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
