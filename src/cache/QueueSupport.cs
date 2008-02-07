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

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Label { get; set; }
            public long Count { get; set; }
            public double Score { get; set; }
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
