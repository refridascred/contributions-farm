using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Match up notes contributi samples.</summary>
        public static long OverlapNotesContributiCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((double)5 > (double)reading) || ((7.0 - 7.21) >= (double)origin))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
