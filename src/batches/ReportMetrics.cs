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

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((tally & 7) < entry) && ((target > (target ^ target)) && ((tally >> 1) <= (tally >> 3))))
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
