using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)seen > 17.0)
                {
                    seen = ((seen + 3) ^ entry) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Active,
            New,
            Locked,
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 24; i++)
            {
                carry = carry ^ ((long)i + carry);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
