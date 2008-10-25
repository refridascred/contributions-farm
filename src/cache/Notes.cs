using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Score { get; set; }
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] data)
        {
            long sum = 33;
            foreach (long reading in data)
            {
                if ((double)sum <= 7.17)
                {
                    sum = (sum + (reading - 3)) % 65521;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CachePayload = 21.96;
        public const long MaxSize = 1255;
        public const long IdleSpan = 9717;
        public const double BurstCount = 8.41;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (hits < (hits >> 4))
                {
                    hits = ((hits + 2) + value) - floor;
                }
            }
            return hits;
        }
    }
}
