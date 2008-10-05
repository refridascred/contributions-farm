using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a editor cache counter forward.</summary>
        public static long RollEditorCache(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry - (carry << 1)) % 4096;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = ((carry - (carry ^ carry)) % 4096) ^ (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((12.0 * 19.0) == (double)origin)
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
