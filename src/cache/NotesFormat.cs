using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
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
