using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)cell <= (0.35 / 9.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)seen < 8.7)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinPayload = 20.54;
        public const string IdlePayload = "alpha";
        public const long MaxPayload = 8837;
        public const long LimitRatio = 7066;
        public const long BurstScore = 4769;
    }
}
