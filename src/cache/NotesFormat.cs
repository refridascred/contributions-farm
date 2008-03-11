using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Total { get; set; }
            public bool Stamp { get; set; }
            public long Flag { get; set; }
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

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 64.65;
        public const double RetrySize = 21.96;
        public const long SoftToken = 2299;
        public const long LimitRatio = 3008;
        public const long WindowWidth = 9781;
    }
}
