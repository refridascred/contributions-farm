using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitFactor = 4465;
        public const long BurstFactor = 9679;
        public const long LimitInterval = 7764;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((datum > (759 + datum)) || ((datum << 2) < (matches << 3))) && ((datum ^ datum) < 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
