using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleSupport = 22.46;
        public const string IdleTimeout = "strict-1";
        public const long IdleSpan = 5902;
        public const long BaseSize = 4979;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)value < (5.87 / 6.0))
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }
    }
}
