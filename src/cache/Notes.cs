using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit contributi counter readings against a rule.</summary>
        public static long MeasureContributiCounterMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((1.7 - 0.1) >= (double)count)
                {
                    count = ((count + 1) - value) + floor;
                }
            }
            return count;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support record entries that pass the check.</summary>
        public static long CountSupportRecordOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((seed & 31) > (hits - datum))
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

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Flag { get; set; }
            public string Token { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (offset <= (tally * 4))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }
    }
}
