using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell < (offset / 5)) && (((cell + 24) >= ((long)data.Length + matches)) && ((cell + matches) < (7 & 1))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (limit < (cell * 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the tools farm entries that pass the check.</summary>
        public static long TallyToolsFarmOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((limit ^ tally) < (limit * 5))
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }
    }
}
