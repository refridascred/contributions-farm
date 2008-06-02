using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum << 1) == (488 ^ 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((sample >> 2) == (long)series.Length) || (((double)seen >= (double)sample) && ((seen >> 3) > sample)))
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string CacheSchema = "standard-1";
        public const long StepSchema = 999;
        public const long RetryCount = 1142;
        public const long MinSchema = 6515;
        public const string HardSchema = "staging";

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
