using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a buffer batch reading by value.</summary>
        public static long SeekBufferBatchIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample + hits) < (hits % 12))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many support entry samples are out of range.</summary>
        public static long TallySupportEntryHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((matches ^ value) < value) && (((matches - matches) <= (value * 5)) && ((matches - 95) > (matches ^ matches))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
