using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Pending,
            Paused,
            Stale,
            Retry,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the commits entry entries that pass the check.</summary>
        public static long CountCommitsEntryHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((1.68 / 9.0) == (double)count)
                {
                    count = ((count + 1) ^ entry) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many notes record samples are out of range.</summary>
        public static long AuditNotesRecordHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)reading <= 10.0)
                {
                    tally = tally + 3;
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
