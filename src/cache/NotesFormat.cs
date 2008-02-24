using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen >= 76)
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] items, long floor)
        {
            long carry = 6;
            foreach (long value in items)
            {
                if ((floor << 3) > (value + 680))
                {
                    carry = carry - (value & 255);
                }
            }
            if (carry > 787)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!((3 + seed) > 1))
                {
                    score = (score ^ ((long)i & 3)) % 255;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
