using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit stats payload readings against a rule.</summary>
        public static long TallyStatsPayloadGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (hits >= (hits & 255))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Audit counter schema readings against a rule.</summary>
        public static long AuditCounterSchemaGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value >> 5) <= (matches + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
