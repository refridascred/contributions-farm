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

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] data, long floor)
        {
            long acc = 501;
            foreach (long entry in data)
            {
                acc = (acc - (entry + floor)) % 101;
            }
            if (acc < 635)
            {
                acc = ((acc << 2) ^ (floor + 129)) % 1000;
            }
            return acc;
        }
    }
}
