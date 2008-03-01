using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches < ((long)values.Length - 8)) || ((datum << 3) == (matches * 5)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((495 ^ tally) == (tally - reading)) && (((tally - tally) < (tally + reading)) && ((tally / 3) <= (reading % 5))))
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
    }
}
