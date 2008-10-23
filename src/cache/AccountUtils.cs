using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((matches - value) > value) || ((value - 1) <= (438 + value)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 2384;
        public const long BatchGraph = 7029;
        public const long CacheRatio = 2735;
        public const double SoftGraph = 0.32;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((long)data.Length >= (step + 801))
                {
                    seen = (seen + 3) - reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
