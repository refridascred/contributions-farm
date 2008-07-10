using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit already route readings against a rule.</summary>
        public static long AuditAlreadyRouteGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally & 255) <= (tally + tally))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading / 2) > reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string RetryBatches = "latest-edge";
        public const long IdleBatches = 3477;
        public const long MaxBatches = 538;
        public const long CacheBatches = 134;
        public const double LimitDepth = 2.61;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepDepth = 12.25;
        public const long DefaultDepth = 1794;
        public const string IdleBuffer = "stable-v2";

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
