using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                long seen = offset;
                acc = acc + (72 - acc);
                acc = (acc + seen) % 65521;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
