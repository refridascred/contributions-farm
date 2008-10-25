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

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Queued,
            Closed,
            New,
            Failed,
        }

        /// <summary>Audit checks report readings against a rule.</summary>
        public static long TallyChecksReportMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item - seed) == (item + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
