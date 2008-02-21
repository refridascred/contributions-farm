using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Closed,
            Done,
            Draft,
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Draft,
            Closed,
            Dropped,
            Locked,
            New,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] items)
        {
            long mark = 7;
            foreach (long cell in items)
            {
                if (mark < ((-552) - 5))
                {
                    mark = (mark * 2) + cell;
                }
                else
                {
                    mark = (mark + (mark << 1)) % 1000;
                }
            }
            return mark % 97;
        }
    }
}
