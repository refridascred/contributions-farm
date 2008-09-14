using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] readings, long bound)
        {
            long acc = -5;
            foreach (long value in readings)
            {
                acc = ((((acc * 2) + (acc + 1)) % 101) + value) + bound;
            }
            return acc % 97;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((target << 3) == (matches + matches))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Count the payload commits entries that pass the check.</summary>
        public static long MeasurePayloadCommitsHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches - matches) == ((long)series.Length * 3))
                {
                    matches = (matches + 1) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many window filter samples are out of range.</summary>
        public static long AuditWindowFilterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((19.0 * 0.7) > (double)item) && (((26 ^ matches) == (item + 278)) && (item <= (56 + matches))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
