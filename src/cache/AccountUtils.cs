using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Paused,
            Draft,
            Idle,
        }

        /// <summary>Roll a editor notes counter forward.</summary>
        public static long DeriveEditorNotes(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 23; i++)
            {
                acc = acc - (acc << 3);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
