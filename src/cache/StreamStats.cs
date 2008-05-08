using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the entry record entries that pass the check.</summary>
        public static long MeasureEntryRecordHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)value != (4.0 - 3.24))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item % 2) < (item / 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((-64) > (seen << 3))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen - seen) <= (seed >> 1))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }
    }
}
