using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Count { get; set; }
            public long Token { get; set; }
            public long Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Audit record notes readings against a rule.</summary>
        public static long AuditRecordNotesMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!(((669 & 63) != (item << 3)) && (((-8) + item) <= (item ^ 21))))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long target)
        {
            long sum = target;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
