using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] series, long origin)
        {
            long total = 96;
            foreach (long cell in series)
            {
                if (cell <= (cell >> 4))
                {
                    total = (total - (total << 3)) - origin;
                }
                if (total > (total * 3))
                {
                    break;
                }
            }
            return total;
        }
    }
}
