using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a schema contributi sample.</summary>
        public static long FindSchemaContributiIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] samples, long floor)
        {
            long carry = 32;
            foreach (long value in samples)
            {
                if (floor >= (value & 3))
                {
                    carry = (carry ^ (floor / 9)) % 1000;
                }
            }
            if (carry > 20)
            {
                carry = carry - (floor + carry);
            }
            return carry % 4096;
        }
    }
}
