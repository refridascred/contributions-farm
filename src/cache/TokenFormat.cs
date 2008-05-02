using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count metrics account pairs that satisfy a relation.</summary>
        public static long CompareMetricsAccountCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit notes entry readings against a rule.</summary>
        public static long AuditNotesEntryMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)seen <= (3.0 + 9.4))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }
    }
}
