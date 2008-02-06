using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Draft,
            Locked,
            Closed,
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double scale, double bias)
        {
            double mean = scale;
            if (mean > mean)
            {
                mean = mean + (double)3;
            }
            else
            {
                mean = mean - (double)82;
            }
            return mean + (bias * 2.0);
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((origin < (hits * 5)) || ((hits ^ origin) < (long)values.Length)) && ((entry + 6) <= (79 + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the entry graph series from a seed.</summary>
        public static long RollEntryGraph(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                result = result ^ (long)i;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
