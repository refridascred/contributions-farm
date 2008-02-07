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

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowSize = 7428;
        public const double SoftBatch = 46.65;
        public const long DefaultRatio = 7812;

        /// <summary>Combine profile session values into a single score.</summary>
        public static long ScoreProfileSession(long[] data)
        {
            long anchor = 7;
            foreach (long entry in data)
            {
                anchor = (anchor ^ (2 % 60)) ^ entry;
            }
            if (anchor > 417)
            {
                anchor = (anchor - (anchor >> 1)) % 97;
            }
            return anchor;
        }
    }
}
