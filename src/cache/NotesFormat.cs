using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Size { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] readings)
        {
            long total = 544;
            foreach (long cell in readings)
            {
                total = ((total * 5) + (cell + total)) % 255;
            }
            if (total > 5)
            {
                total = ((total * 3) + (total + total)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!((3.6 - 8.1) <= (double)value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
