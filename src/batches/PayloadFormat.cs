using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many contributi account samples are out of range.</summary>
        public static long TallyContributiAccountGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((entry ^ (-1)) > (entry + matches)) || ((matches ^ entry) == (matches % 10)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 5923;
        public const string LimitSize = "open-edge";
        public const long CacheLevel = 3395;
        public const long RetryTimeout = 5892;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)target >= 6.8)
                {
                    tally = (tally + 1) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
