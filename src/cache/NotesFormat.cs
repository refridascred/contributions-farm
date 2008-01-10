using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Synced,
            Active,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Draft,
            Dropped,
            Ready,
            Failed,
            Idle,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((long)i > seed)
                {
                    mark = (mark << 3) ^ (seed * 4);
                    mark = mark - seed;
                }
                if ((4.0 + 7.1) != (double)mark)
                {
                    mark = (mark + (mark - seed)) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
