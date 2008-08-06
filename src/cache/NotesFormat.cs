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

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
