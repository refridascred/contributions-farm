using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            New,
            Stale,
            Queued,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (17.0 < (double)(long)readings.Length)
                {
                    seen = ((seen + 1) ^ item) - seed;
                }
            }
            return seen;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry + 90) < (entry * 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
