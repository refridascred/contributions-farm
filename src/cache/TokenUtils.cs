using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((double)hits < 2.3) || ((hits & 15) != (hits + hits)))
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit record graph readings against a rule.</summary>
        public static long CountRecordGraphMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((22 > (target - target)) && (target < (9 - 18))) && ((1.97 / 6.0) > (double)target))
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Synced,
            Draft,
            Done,
        }
    }
}
