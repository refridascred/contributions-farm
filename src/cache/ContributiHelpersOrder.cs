using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] series)
        {
            long result = 2;
            foreach (long sample in series)
            {
                result = (result - ((long)series.Length * 3)) ^ sample;
            }
            return result;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((count << 3) >= (count + reading)) || ((double)count >= (6.74 / 3.0)))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Audit checks contributi readings against a rule.</summary>
        public static long MeasureChecksContributiHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry << 3) >= 8)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
