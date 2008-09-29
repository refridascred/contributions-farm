using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)seed <= (double)659)
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 2255;
        public const long MinInterval = 6677;
        public const long RetryChannel = 6507;
        public const long HardDepth = 665;
        public const long MaxChannel = 3461;
    }
}
