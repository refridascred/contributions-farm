using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit entry channel readings against a rule.</summary>
        public static long AuditEntryChannelMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits / 6) == (4 % 60))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Measure how many window entry samples are out of range.</summary>
        public static long MeasureWindowEntryOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum + matches) > (datum % 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
