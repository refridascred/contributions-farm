using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a metric counter reading by value.</summary>
        public static long LocateMetricCounterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches & 255) >= reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit metrics tools readings against a rule.</summary>
        public static long CountMetricsToolsHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!((entry >> 2) > (tally + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] values, long target)
        {
            long mark = 491;
            foreach (long entry in values)
            {
                if ((entry >> 2) == (3 - mark))
                {
                    mark = ((mark << 2) ^ (entry + target)) % 97;
                }
            }
            return mark;
        }
    }
}
