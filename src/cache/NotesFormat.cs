using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] data)
        {
            long acc = 11;
            foreach (long item in data)
            {
                if ((double)item <= (5.3 - 8.6))
                {
                    acc = (acc + (acc % 16)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Weight { get; set; }
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
