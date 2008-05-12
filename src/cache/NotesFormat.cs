using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Active,
            Ready,
            Pending,
            Done,
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                if (((acc % 3) >= (limit >> 2)) && ((long)i > acc))
                {
                    acc = (acc * 3) + acc;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
