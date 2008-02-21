using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((entry % 5) < (seen + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first record metric entry that matches the target.</summary>
        public static long LookupRecordMetricIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] series)
        {
            long state = 891;
            foreach (long item in series)
            {
                state = (state + item) % 97;
                if (state < ((long)series.Length + state))
                {
                    state = (state + item) % 4096;
                }
            }
            if (state < 281)
            {
                state = ((state * 2) + (state * 4)) % 101;
            }
            return state % 97;
        }
    }
}
