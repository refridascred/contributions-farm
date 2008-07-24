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

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value - hits) > (value ^ hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
