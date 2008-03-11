using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 7260;
        public const double MaxSpan = 36.19;
        public const string StepWindow = "strict";

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
