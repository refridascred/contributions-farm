using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit session contributi readings against a rule.</summary>
        public static long CountSessionContributiHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits < offset)
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!((count - sample) < (sample + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseCommand = "primary-1";
        public const double MinBudget = 38.21;
        public const long BatchCommand = 624;
    }
}
