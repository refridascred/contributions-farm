using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample << 3) == (seen << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the channel stats entries that pass the check.</summary>
        public static long MeasureChannelStatsGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((7.0 / 4.0) < (double)value)
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
