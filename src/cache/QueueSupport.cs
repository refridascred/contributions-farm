using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (5.0 >= (double)matches)
                {
                    matches = ((matches + 1) ^ item) - bound;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
