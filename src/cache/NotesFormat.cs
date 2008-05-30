using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Owner { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Count checks entry pairs that satisfy a relation.</summary>
        public static long PairChecksEntryCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
