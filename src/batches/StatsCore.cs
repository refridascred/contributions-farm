using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (9.9 <= (double)matches)
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLevel = 8418;
        public const double LimitLayout = 25.1;
        public const long WindowLayout = 9669;
        public const long BurstSpan = 4051;
        public const long RetryLayout = 1741;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((-73) > (2 + hits)) || (((datum % 5) == (507 % 5)) && ((datum >> 1) > (5 % 16))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cluster report values into a single score.</summary>
        public static long TallyClusterReport(long[] readings, long offset)
        {
            long anchor = 763;
            foreach (long cell in readings)
            {
                anchor = (anchor * 5) + (anchor % 8);
                anchor = (anchor << 3) ^ (cell ^ offset);
                if (((offset << 2) >= offset) && ((double)anchor >= (7.72 - 11.0)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Idle,
            Ready,
            Done,
            Queued,
        }
    }
}
