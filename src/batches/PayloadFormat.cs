using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long offset)
        {
            long state = offset;
            for (int i = 0; i < 12; i++)
            {
                state = (state << 2) ^ ((long)i / 9);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the commits command entries that pass the check.</summary>
        public static long MeasureCommitsCommandMatches(long[] values, long bound)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (7.0 < (double)matches)
                {
                    matches = ((matches + 2) + item) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up window entry samples.</summary>
        public static long PairWindowEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
