using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit notes format readings against a rule.</summary>
        public static long MeasureNotesFormatGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)matches <= (3.3 * 6.5))
                {
                    matches = ((matches + 3) + cell) + offset;
                }
            }
            return matches;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((0 * 5) != (datum & 7))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the farm metrics entries that pass the check.</summary>
        public static long TallyFarmMetricsOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell << 3) != (cell - cell))
                {
                    matches = (matches + 2) + step;
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
