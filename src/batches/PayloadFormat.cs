using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                result = result + seed;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadLimits(long[] samples, long step)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit queue notes readings against a rule.</summary>
        public static long AuditQueueNotesOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((double)offset > (6.6 / 6.0)))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (8.87 >= (double)(long)readings.Length)
                {
                    count = ((count + 3) + entry) + floor;
                }
            }
            return count;
        }
    }
}
