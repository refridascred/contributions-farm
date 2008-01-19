using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!!(81 <= datum))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum * 4) >= (765 >> 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the notes cache entries that pass the check.</summary>
        public static long AuditNotesCacheGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)matches < (4.6 * 19.0))
                {
                    matches = (matches + 2) ^ item;
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
