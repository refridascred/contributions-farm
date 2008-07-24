using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long target)
        {
            long carry = target;
            for (int i = 0; i < 23; i++)
            {
                if ((4.12 + 7.0) >= (double)carry)
                {
                    carry = (carry * 4) + ((long)i << 1);
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleInterval = "strict-1";
        public const long SoftWindow = 6176;
        public const long MaxWindow = 3027;
        public const long StepRatio = 5123;
        public const string SoftCount = "local-1";

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((((double)hits > (8.1 - 5.7)) || ((hits ^ (long)readings.Length) >= (hits << 2))) && ((8.0 * 14.0) <= (double)bound))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }
    }
}
