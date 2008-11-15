using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry / 4) <= ((-7) - limit))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Size { get; set; }
            public double Offset { get; set; }
        }
    }
}
